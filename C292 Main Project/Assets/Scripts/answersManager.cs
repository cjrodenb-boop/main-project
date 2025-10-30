using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // imports are not automatic?
using TMPro;

public class answersManager : MonoBehaviour
{
    [SerializeField] private Button[] buttons;

    private string[] answers = new string[]
    {
        "Nigeria", "Kenya", "Ethiopia", "Ghana", "China", "India", "Japan", "Thailand",
        "Philippines", "Mongolia", "Bhutan", "United States", "Cuba", "Brazil", "Chile",
        "Peru", "France", "Germany", "Italy", "Spain", "Poland", "Norway", "Albania",
        "Austrailia", "Kiribati"
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AnswerPicker();
    }
    
    public void AnswerPicker()
    {
        List<string> answersCopy = new List<string>(answers);
        

        List<string> selected = new List<string>();
        for (int i = 0; i < 4; i++)
        {
            int idx = Random.Range(0, answersCopy.Count);
            selected.Add(answersCopy[idx]);
            answersCopy.RemoveAt(idx);
        }

        for (int i = 0; i < selected.Count; i++)
        {
            string temp = selected[i];
            int idx = Random.Range(i, selected.Count);
            selected[i] = selected[idx];
            selected[idx] = temp;
        }

        for (int i = 0; i < buttons.Length; i++)
        {
            TMP_Text buttonText = buttons[i].GetComponentInChildren<TMP_Text>(); // im not sure if this is correct
            buttonText.text = selected[i];
        }  
    } 
}
