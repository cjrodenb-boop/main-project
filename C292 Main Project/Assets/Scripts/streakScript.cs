using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class streakScript : MonoBehaviour
{
    public int Streak => streak;
    public int streak = 0;
    [SerializeField] TMP_Text streakText;


    public void IncreaseStreak()

    {
        streak += 1; 
    }
    

    public void ResetStreak()
    {
        streak = 0;
    }

    public void UpdateStreak()
    {
        streakText.text = streak.ToString();
    }

}
