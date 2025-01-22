using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DisplayHighscore : MonoBehaviour
{
    public TextMeshProUGUI highScore;

    void Start()
    {
        highScore.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0).ToString()}";
    }

    public void ResetScore()
    {
        ScoreScript.score = 0;
    }
}
