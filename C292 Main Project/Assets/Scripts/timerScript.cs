using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerScript : MonoBehaviour
{
    float currentTime;
    public float startingTime = 15f;

    [SerializeField] TMP_Text countdownText;
    [SerializeField] private screenSwitchScript sm;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private questionManager qm;
    private bool running = false;
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
            enabled = false;
            qm.ForceAnswer(); 

            if (!endScreen.activeSelf) // i looked up .activeSelf
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
    
    public void TimerReset()
    {
        currentTime = startingTime;
        enabled = true;
    }
}
