using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreScript : MonoBehaviour
{
    private int score = 0;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        UpdateScore();
    }



    public void CorrectScore()
    {
        score += 50;
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
