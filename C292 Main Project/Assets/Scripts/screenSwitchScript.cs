using UnityEngine;

public class screenSwitchScript : MonoBehaviour
{

    [SerializeField] private GameObject questionScreen;
    [SerializeField] private GameObject answerScreen;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private AudioSource funSong;
    [SerializeField] private questionManager qm;
    [SerializeField] private answersManager am;
    [SerializeField] private timerScript t;
    [SerializeField] private scoreScript s;
    [SerializeField] private correctCountScript cs;
    [SerializeField] private streakScript ss;

    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        funSong.Play();
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        playScreen.SetActive(true);
        questionScreen.SetActive(false);
        answerScreen.SetActive(false);
        endScreen.SetActive(false);
    }


    public void StartGame()
    {
        funSong.Stop();
        playScreen.SetActive(false);
        questionScreen.SetActive(true);
        ss.ResetStreak();
        ss.UpdateStreak();
        answerScreen.SetActive(false);
        endScreen.SetActive(false);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
        qm.QuestionPicker();
        am.AnswerPicker(qm.CorrectAnswer); 
        t.StartTimer();
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
        t.StopTimer();
    }

    public void End()
    {
        funSong.Play();
        questionScreen.SetActive(false); // found bug with answer and end screen
        answerScreen.SetActive(false);
        endScreen.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        t.StopTimer();
    }

    public void ResetGame()
    {
        ss.ResetStreak();
        ss.UpdateStreak();
        qm.enabled = true;
        am.enabled = true;
        t.TimerReset();
        qm.ResetQuestions();
        s.ResetScore();
        cs.ResetCount();
        playScreen.SetActive(true);
        endScreen.SetActive(false);
        questionScreen.SetActive(false);
        answerScreen.SetActive(false);
    }
}
