using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // imports are not automatic?
using TMPro;

public class answersManager : MonoBehaviour
{
    [SerializeField] private scoreScript s;
    [SerializeField] private questionManager qm;

    [SerializeField] private Button[] buttons;

    private string[] answers = new string[]
    {
        "Nigeria", "Kenya", "Ethiopia", "Ghana", "China", "India", "Japan", "Thailand",
        "Philippines", "Mongolia", "Bhutan", "United States", "Cuba", "Brazil", "Chile",
        "Peru", "France", "Germany", "Italy", "Spain", "Poland", "Norway", "Albania",
        "Austrailia", "Kiribati"
    };

    public void AnswerPicker(string correctAnswer)
    {
        List<string> wrong = new List<string>(answers);
        wrong.Remove(correctAnswer);
        

        List<string> selected = new List<string>();
        for (int i = 0; i < 3; i++)
        {
            int idx = Random.Range(0, wrong.Count);
            selected.Add(wrong[idx]);
            wrong.RemoveAt(idx);
        }

        selected.Add(correctAnswer);

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
