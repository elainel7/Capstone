using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int world { get; private set; } = 1;
    public int stage { get; private set; } = 1;
    public int lives { get; private set; } = 3;
    public int coins { get; private set; } = 0;

    /// <summary>Elapsed time in seconds since the current level started (frozen when level is completed).</summary>
    public float ElapsedTime => _levelCompletedTime >= 0 ? _levelCompletedTime : Time.time - _levelStartTime;
    /// <summary>Completion time in seconds for the last completed level (0 if none yet).</summary>
    public float LastCompletionTime { get; private set; }

    private float _levelStartTime;
    private float _levelCompletedTime = -1f;

    private void Awake()
    {
        if (Instance != null) {
            DestroyImmediate(gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this) {
            Instance = null;
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        NewGame();
    }

    public void NewGame()
    {
        lives = 3;
        coins = 0;

        LoadLevel(1, 1);
    }

    public void GameOver()
    {
        NewGame();
    }

    public void LoadLevel(int world, int stage)
    {
        this.world = world;
        this.stage = stage;
        _levelCompletedTime = -1f;

        SceneManager.LoadScene($"{world}-{stage}");
        _levelStartTime = Time.time;
    }

    /// <summary>Call when the player reaches the goal (e.g. flag). Stops the level timer.</summary>
    public void CompleteLevel()
    {
        if (_levelCompletedTime < 0)
        {
            _levelCompletedTime = Time.time - _levelStartTime;
            LastCompletionTime = _levelCompletedTime;
        }
    }

    public void NextLevel()
    {
        LastCompletionTime = ElapsedTime;
        LoadLevel(world, stage + 1);
    }

    public void ResetLevel(float delay)
    {
        CancelInvoke(nameof(ResetLevel));
        Invoke(nameof(ResetLevel), delay);
    }

    public void ResetLevel()
    {
        lives--;

        if (lives > 0) {
            LoadLevel(world, stage);
        } else {
            GameOver();
        }
    }

    public void AddCoin()
    {
        coins++;

        if (coins == 100)
        {
            coins = 0;
            AddLife();
        }
    }

    public void AddLife()
    {
        lives++;
    }

}
