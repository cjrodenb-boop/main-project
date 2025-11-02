using UnityEngine;
using TMPro;

public class questionManager : MonoBehaviour
{

    [SerializeField] private TMP_Text questionText;

    private string[] questions = new string[]
    {
        "Which West African country is the most populous on the continent? c",
        "Nairobi is the capital of which country? c",
        "Which country is considered the origin of coffee? c",
        "Which country is known for cocoa production? c",
        "Which country is the most populous in the world? c",
        "Which country’s flag is shown below? c",
        "Which country consists of four main islands and is famous for Mount Fuji? c",
        "Which country has the nickname “Land of Smiles c”?",
        "Which country consists of more than 7,000 islands? c",
        "Which landlocked country lies between Russia and China? c",
        "Which country has Dzongkha as an official language? c",
        "Which country doesn’t have an official language? c",
        "Which country is the largest island in the Caribbean? c",
        "Which South American country is the largest by area and population in the continent and speaks Portuguese? c",
        "Which country is long and narrow, stretching along the western edge of the continent? c",
        "Which country has Quechua as an official language? c",
        "Which of the following countries is known for the Eiffel Tower? c",
        "Which of the following countries shares a border with Denmark? c",
        "Rome is the capital of which country? c",
        "Which country occupies most of the Iberian Peninsula? c",
        "Which country is home to the World's largest castle? c",
        "Oslo is the capital of which country? c",
        "Which European country borders Montenegro, Kosovo, North Macedonia, and Greece? c",
        "Canbara is the capital of which country? c",
        "Which country has a non-phonetic spelling?"
    };

    private string[] correctAnswers = new string[]
    {
        "Nigeria", "Kenya", "Ethiopia", "Ghana", "China", "India", "Japan", "Thailand",
        "Philippines", "Mongolia c", "Bhutan c", "United States c", "Cuba c", "Brazil c", "Chile",
        "Peru", "France", "Germany c", "Italy c", "Spain c", "Poland c", "Norway", "Albania",
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
        int idx = Random.Range(0, questions.Length);
        questionText.text = questions[idx];
        CorrectAnswer = correctAnswers[idx];
    }
}
