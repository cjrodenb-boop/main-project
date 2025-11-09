using UnityEngine;

public class screenSwitchScript : MonoBehaviour
{

    [SerializeField] private GameObject questionScreen;
    [SerializeField] private GameObject answerScreen;
    [SerializeField] private questionManager qm;
    [SerializeField] private answersManager am;
    [SerializeField] private timerScript t;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questionScreen.SetActive(true);
        answerScreen.SetActive(false);
        qm.QuestionPicker();
        am.AnswerPicker(qm.CorrectAnswer);
    }

    public void Question()
    {
        questionScreen.SetActive(true);
        answerScreen.SetActive(false);
        qm.QuestionPicker();
        am.AnswerPicker(qm.CorrectAnswer);
        t.TimerReset();
    }

    public void Answer()
    {
        questionScreen.SetActive(false);
        answerScreen.SetActive(true);
    }
}
