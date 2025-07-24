using UnityEngine;

public static class SaveManager
{
    public static void SaveHighScore(string name, int score)
    {
        PlayerPrefs.SetString("HighScoreName", name);
        PlayerPrefs.SetInt("HighScore", score);
    }

    public static string GetHighScoreName()
    {
        return PlayerPrefs.GetString("HighScoreName", "None");
    }

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }
}
