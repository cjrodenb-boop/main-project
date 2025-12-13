using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class answerButtonScript : MonoBehaviour
{
    public TMP_Text buttonText;
    public questionManager qm; 
    
    // I used google to figure out that I needed to use Unity's OnClick() to accomplish this.
    public void OnClick()
    {
        qm.AnswerChosen(buttonText.text);
    }
    
}
