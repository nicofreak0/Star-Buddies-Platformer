using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;
    
    void Start()
    {
        UpdateScoreText();
    }

    public void SetHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }      
    }

    private void OnApplicationQuit()
    {
        SetHighScore();
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