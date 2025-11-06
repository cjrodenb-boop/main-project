using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class answerButtonScript : MonoBehaviour
{
    public TMP_Text buttonText;
    public questionManager qm; 
    
    public void OnClick()
    {
        qm.MethodName(buttonText.text);
    }
    
}
