using UnityEngine;
using TMPro;

public class questionManager : MonoBehaviour
{

    [SerializeField] private TMP_Text questionText;

    private string[] questions = new string[]
    {
        "Which West African country is the most populous on the continent?",
        "Which country’s flag is shown below?",
        "Which country is considered the origin of coffee?",
        "Which country is known for cocoa production?",
        "Which country is the most populous in the world?",
        "Which country’s flag is shown below?",
        "Which country consists of four main islands and is famous for Mount Fuji?",
        "Which country has the nickname “Land of Smiles”?",
        "Which landlocked country lies between Russia and China?",
        "Which country has Dzongkha as an official language?",
        "Which country doesn’t have an official language?",
        "Which country’s flag is shown below?",
        "Which South American country is the largest by area and population in the continent and speaks Portuguese?",
        "Which country is long and narrow, stretching along the western edge of the continent?",
        "Which country has Quechua as an official language?",
        "Which of the following countries is known for the Eiffel Tower?",
        "Which of the following countries shares a border with Denmark?",
        "Rome is the capital of which country?",
        "Which country occupies most of the Iberian Peninsula?",
        "Which country is located in Europe?",
        "Oslo is the capital of which country?",
        "Which European country borders Montenegro, Kosovo, North Macedonia, and Greece?",
        "Canbara is the capital of which country?"
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QuestionPicker();
    }

    
    public void QuestionPicker()
    {
        int idx = Random.Range(0, questions.Length);
        questionText.text = questions[idx];
        
    
    }
}
