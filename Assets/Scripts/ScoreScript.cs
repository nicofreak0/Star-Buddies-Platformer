using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;
    public Text highScore;
    
    void Start()
    {
        UpdateScoreText();

        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void HighScore()
    {
        PlayerPrefs.SetInt("HighScore", score);
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    public void DeductPoints(int points)
    {
        score -= points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}