using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text usernameText;

    void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.score;
        usernameText.text = "Player: " + GameManager.Instance.playerName;
    }
}
