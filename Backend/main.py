from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
from typing import List
from sqlalchemy import create_engine, Column, Integer, String, Float
from sqlalchemy.orm import declarative_base, sessionmaker

app = FastAPI()

# Database Setup
engine = create_engine("sqlite:///leaderboard.db")
SessionLocal = sessionmaker(bind=engine)
Base = declarative_base()


class Score(Base):
    __tablename__ = "scores"

    id = Column(Integer, primary_key=True, index=True)
    username = Column(String)
    completion_time = Column(Float)
    coins = Column(Integer)
    final_score = Column(Float)


Base.metadata.create_all(bind=engine)


class GameResult(BaseModel):
    username: str
    completion_time: float
    coins_collected: int


class LeaderboardEntry(BaseModel):
    username: str
    final_score: float


# Score Logic - TBDDD!!!
def calculate_score(time: float, coins: int) -> float:
    """
    Higher score is better.
    Faster time = higher score.
    Coins/whatever item we choose add bonus.
    """

    if time <= 0:
        raise ValueError("Invalid completion time")

    base_time_score = 10000 / time
    coin_bonus = coins * 50

    return base_time_score + coin_bonus


# API Endpoints
@app.post("/submit_score")
def submit_score(result: GameResult):

    final_score = calculate_score(
        result.completion_time,
        result.coins_collected
    )

    db = SessionLocal()

    new_score = Score(
        username=result.username,
        completion_time=result.completion_time,
        coins=result.coins_collected,
        final_score=final_score
    )

    db.add(new_score)
    db.commit()
    db.refresh(new_score)

    db.close()

    return {
        "message": "Score submitted!",
        "final_score": final_score
    }


@app.get("/leaderboard", response_model=List[LeaderboardEntry])
def get_leaderboard():

    db = SessionLocal()

    top_scores = (
        db.query(Score)
        .order_by(Score.final_score.desc())
        .limit(10)
        .all()
    )

    db.close()

    return [
        LeaderboardEntry(
            username=s.username,
            final_score=s.final_score
        )
        for s in top_scores
    ]