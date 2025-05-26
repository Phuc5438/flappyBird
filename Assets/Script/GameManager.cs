using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public DisplayScore displayScore;

    public int score = 0;
    private bool isGameStarted = false;
    private bool isGameEnded = false;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);

        if (displayScore != null) displayScore.ShowScore(score);
    }

    public void StartGame()
    {
        isGameStarted = true;
    }

    public void EndGame()
    {
        isGameEnded = true;
    }
}