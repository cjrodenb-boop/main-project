using UnityEngine;

public class screenSwitchScript : MonoBehaviour
{

    [SerializeField] private GameObject questionScreen;
    [SerializeField] private GameObject answerScreen;
    [SerializeField] private questionManager qm;
    [SerializeField] private answersManager am;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questionScreen.SetActive(true);
        answerScreen.SetActive(false);
        qm.QuestionPicker();
        am.AnswerPicker();
    }

    public void Question()
    {
        questionScreen.SetActive(true);
        answerScreen.SetActive(false);
        qm.QuestionPicker();
        am.AnswerPicker();
    }

    public void Answer()
    {
        questionScreen.SetActive(false);
        answerScreen.SetActive(true);
    }
}
