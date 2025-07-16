using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int currentScore = 0;
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        // Basic singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    

    // Score handling
    public void AddScore(int amount)
    {
        currentScore += amount;
        Debug.Log("Score: " + currentScore);
        UpdateScoreUI();
    }

    public int GetScore()
    {
        return currentScore;
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Donuts collected: " + currentScore;
        }
    }
}
