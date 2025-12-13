using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerScript : MonoBehaviour
{
    public float CurrentTime => currentTime;
    public float currentTime;
    public float startingTime = 15f;

    [SerializeField] TMP_Text countdownText;
    [SerializeField] private screenSwitchScript sm;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private questionManager qm;
    private bool running = false;

    // I used a tutorial that I linked in the submission to help me work on this.
    void Start()
    {
        running = false;
        enabled = true;
    }
    void Update()
    {
        if (!running)
        {
            return;
        }
   

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("Time Remaining: 0");

        if (currentTime <= 0)
        {

            currentTime = 0;
            running = false; 
            enabled = false;
            qm.ForceAnswer(); 

            // I looked up the syntax for this on google.
            if (!endScreen.activeSelf)
            {
                sm.Answer();
            }
        }
    }

    public void StartTimer()
    {
        currentTime = startingTime;
        running = true;
        enabled = true;
    
    }

    public void StopTimer()
    {
        running = false;
        enabled = false;
    }
    
    public void TimerReset()
    {
        currentTime = startingTime;
        running = true; 
        enabled = true;
    }
}
