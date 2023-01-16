using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;

    public Text scoreText;

    public gameObject playButton;

    public gameObject gameOver;

    private int score;

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void IncreaseScore()
    {
        score++;
    }
}
