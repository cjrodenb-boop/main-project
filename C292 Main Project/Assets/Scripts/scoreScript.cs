using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreScript : MonoBehaviour
{
    public int score = 0;
    public int currScore = 0;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] timerScript t;
    [SerializeField] scoreScript s;
    [SerializeField] streakScript ss;

    private void Start()
    {
        UpdateScore();
    }

    public void CorrectScore()
    {
        currScore = 0;
        int streak = ss.Streak;
        float timeLeft = t.CurrentTime;

        if (streak > 1)
        {
           currScore += streak * 50;
        }

        if (timeLeft < 15 && timeLeft > 11)
        {
            currScore += 30;
        }
        else if (timeLeft < 12 && timeLeft > 8)
        {
            currScore += 20;
        }
        else if (timeLeft < 11 && timeLeft > 7)
        {
            currScore += 10;
        }

        currScore += 50; 
        score += currScore;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
}
