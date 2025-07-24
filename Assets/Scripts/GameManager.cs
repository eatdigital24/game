using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string playerName;
    public int score;
    public int highScore;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame(string username)
    {
        playerName = username;
        score = 0;
        SceneManager.LoadScene("Level1");
    }

    public void GameOver()
    {
        if (score > highScore)
        {
            highScore = score;
            SaveManager.SaveHighScore(playerName, highScore);
        }
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
