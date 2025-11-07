using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic; 

public class questionManager : MonoBehaviour
{

    [SerializeField] private TMP_Text questionText;
    [SerializeField] private List<answerButtonScript> answerButtons;

    private List<string> questions = new List<string>()
    {
        "Which West African country is the most populous on the continent?",
        "Nairobi is the capital of which country?",
        "Which country is considered the origin of coffee?",
        "Which country is known for cocoa production?",
        "Which country is the most populous in the world?",
        "Which country’s flag is shown below?",
        "Which country consists of four main islands and is famous for Mount Fuji?",
        "Which country has the nickname “Land of Smiles”?",
        "Which country consists of more than 7,000 islands?",
        "Which landlocked country lies between Russia and China?",
        "Which country has Dzongkha as an official language?",
        "Which country doesn’t have an official language?",
        "Which country is the largest island in the Caribbean?",
        "Which South American country is the largest by area and population in the continent and speaks Portuguese?",
        "Which country is long and narrow, stretching along the western edge of the continent?",
        "Which country has Quechua as an official language?",
        "Which of the following countries is known for the Eiffel Tower?",
        "Which of the following countries shares a border with Denmark?",
        "Rome is the capital of which country?",
        "Which country occupies most of the Iberian Peninsula?",
        "Which country is home to the World's largest castle?",
        "Oslo is the capital of which country?",
        "Which European country borders Montenegro, Kosovo, North Macedonia, and Greece?",
        "Canbara is the capital of which country?",
        "Which country has a non-phonetic spelling?"
    };

    private List<string> correctAnswers = new List<string>()
    {
        "Nigeria", "Kenya", "Ethiopia", "Ghana", "China", "India", "Japan", "Thailand",
        "Philippines", "Mongolia", "Bhutan", "United States", "Cuba", "Brazil", "Chile",
        "Peru", "France", "Germany", "Italy", "Spain", "Poland", "Norway", "Albania",
        "Austrailia", "Kiribati"
    };

    public string CorrectAnswer { get; private set; }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QuestionPicker();
    }


    public void QuestionPicker()
    {
        foreach (var ab in answerButtons)
            ab.GetComponent<Image>().color = Color.white;

        int idx = Random.Range(0, questions.Count);
        questionText.text = questions[idx];
        CorrectAnswer = correctAnswers[idx];
        questions.RemoveAt(idx);
        correctAnswers.RemoveAt(idx);
    }

    public void AnswerChosen(string selectedAnswer)
    {
        foreach (answerButtonScript ab in answerButtons)
        {
            if (ab.buttonText.text == CorrectAnswer)
                ab.GetComponent<Image>().color = new Color(0.6f, 1f, 0.6f);
            else
                ab.GetComponent<Image>().color = new Color(1f, 0.4f, 0.4f, 1f);
        } 
    }
}
