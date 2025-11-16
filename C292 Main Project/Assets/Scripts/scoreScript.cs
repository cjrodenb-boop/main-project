using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreScript : MonoBehaviour
{
    private int score = 0;
    [SerializeField] TMP_Text scoreText;

    public void CorrectScore()
    {
        score += 50;
    }

    public void ResetScore()
    {
        score = 0;
    }

    private void OnEnable()
    {
        scoreText.text = score.ToString();
    }
}
