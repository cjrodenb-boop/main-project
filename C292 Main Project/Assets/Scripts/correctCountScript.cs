using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class correctCountScript : MonoBehaviour
{
    private int correct = 0;
    [SerializeField] TMP_Text correctText;

    private void Start()
    {
        UpdateCount();
    }

    public void AddCount()
    {
        correct += 1;
    }

    public void ResetCount()
    {
        score = 0;
    }

    public void UpdateCount()
    {
        correctText.text = count.ToString();
    }
}
