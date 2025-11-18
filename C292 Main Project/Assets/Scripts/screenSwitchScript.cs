using UnityEngine;

public class screenSwitchScript : MonoBehaviour
{

    [SerializeField] private GameObject questionScreen;
    [SerializeField] private GameObject answerScreen;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private AudioSource endSong;
    [SerializeField] private questionManager qm;
    [SerializeField] private answersManager am;
    [SerializeField] private timerScript t;
    [SerializeField] private scoreScript s;
    [SerializeField] private correctCountScript cs;

    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questionScreen.SetActive(true);
        answerScreen.SetActive(false);
        endScreen.SetActive(false);
        qm.QuestionPicker();
        am.AnswerPicker(qm.CorrectAnswer);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
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

    public void End()
    {
        endSong.Play();
        questionScreen.SetActive(false); // found bug with answer and end screen
        answerScreen.SetActive(false);
        endScreen.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }

    public void ResetGame()
    {
        endSong.Stop();
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
        qm.enabled = true;
        am.enabled = true;
        t.TimerReset();
        qm.ResetQuestions();
        s.ResetScore();
        cs.ResetCount();
        endScreen.SetActive(false);
        questionScreen.SetActive(true);
        answerScreen.SetActive(false);
        qm.QuestionPicker();
        am.AnswerPicker(qm.CorrectAnswer);
    }
}
