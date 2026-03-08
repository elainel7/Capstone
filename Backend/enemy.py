from abc import ABC, abstractmethod
from enum import Enum
from typing import Optional, Tuple


class EnemyState(Enum):
    IDLE = 0
    PATROL = 1
    CHASE = 2
    ATTACK = 3
    STUNNED = 4
    DEAD = 5


class Direction(Enum):
    LEFT = -1
    RIGHT = 1


class GameObject:
    def __init__(self, position: Tuple[float, float]):
        self.position = position
        self.velocity = (0.0, 0.0)
        self.active = True

    def update(self, delta_time: float):
        pass

    def render(self):
        pass

    def destroy(self):
        pass


class Entity(GameObject):
    def __init__(self, position: Tuple[float, float], health: int):
        super().__init__(position)
        self.health = health
        self.max_health = health

    def take_damage(self, amount: int):
        pass

    def is_alive(self) -> bool:
        pass


#Stun/slow mechanism?
class Ability(ABC):
    def __init__(self, cooldown: float):
        self.cooldown = cooldown
        self.current_cooldown = 0.0

    @abstractmethod
    def activate(self, enemy, player):
        pass

    def update(self, delta_time: float):
        pass

    def is_ready(self) -> bool:
        pass


class SlowPlayerAbility(Ability):
    def __init__(self, cooldown: float, slow_duration: float):
        super().__init__(cooldown)
        self.slow_duration = slow_duration

    def activate(self, enemy, player):
        pass

# Base enemy
class Enemy(Entity, ABC):
    def __init__(
        self,
        position: Tuple[float, float],
        health: int,
        speed: float,
        damage: int
    ):
        super().__init__(position, health)

        self.speed = speed
        self.damage = damage
        self.state = EnemyState.IDLE
        self.direction = Direction.LEFT
        self.ability: Optional[Ability] = None

    @abstractmethod
    def move(self, delta_time: float):
        pass

    @abstractmethod
    def attack(self, player):
        pass

    def update(self, delta_time: float):
        pass

    def change_state(self, new_state: EnemyState):
        pass

    def on_collision(self, other):
        pass


# Potential Enemy Types - TBD/TO-DO
class PatrolEnemy(Enemy):
    def __init__(
        self,
        position: Tuple[float, float],
        patrol_range: Tuple[float, float]
    ):
        super().__init__(position, health=3, speed=2.0, damage=1)
        self.patrol_range = patrol_range

    def move(self, delta_time: float):
        pass

    def attack(self, player):
        pass


class FlyingEnemy(Enemy):
    def __init__(
        self,
        position: Tuple[float, float],
        flight_height: float
    ):
        super().__init__(position, health=2, speed=3.0, damage=1)
        self.flight_height = flight_height

    def move(self, delta_time: float):
        pass

    def attack(self, player):
        pass


class SlowDebuffEnemy(Enemy):
    def __init__(
        self,
        position: Tuple[float, float]
    ):
        super().__init__(position, health=4, speed=1.5, damage=1)
        self.ability = SlowPlayerAbility(
            cooldown=5.0,
            slow_duration=3.0
        )

    def move(self, delta_time: float):
        pass

    def attack(self, player):
        pass