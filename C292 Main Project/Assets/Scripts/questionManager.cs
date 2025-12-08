using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic; 

public class questionManager : MonoBehaviour
{


    [SerializeField] private TMP_Text questionText;
    [SerializeField] private TMP_Text factText;
    [SerializeField] private AudioSource correctSound;
    [SerializeField] private AudioSource wrongSound;
    [SerializeField] private screenSwitchScript ss;

    [SerializeField] private scoreScript s;
    [SerializeField] private correctCountScript cs;
    [SerializeField] private streakScript str;

    [SerializeField] private List<answerButtonScript> answerButtons;


    private int counter = 0;
    private const int totalQuestions = 8; // i looked up "const"
    private bool answered = false;


    private List<string> questions = new List<string>()
    {
        "Which West African country is the most populous on the continent?",
        "Nairobi is the capital of which country?",
        "Which country is considered the origin of coffee?",
        "Which country is known for cocoa production?",
        "Which country is the most populous in the world?",
        "Where is the Ganges River located?",
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

    private List<string> funFacts = new List<string>()
    {
        "Nigeria has the highest birth rate of twins.",
        "Kenya is famous for long-distance runners.",
        "Ethiopia was never colonized.",
        "The name Ghana means 'Warrior King'.",
        "Table tennis is China's national sport.",
        "India is the birthplace of chess.",
        "Slurping noodles is considered polite in Japan.",
        "Red Bull was inspired by a Thai energy drink.",
        "Karaoke is the national pastime of the Philippines.",
        "Mongolia is known for the Gobi Desert.",
        "Bhutan is home to the highest unclimbed mountain in the world.",
        "Alaska has the longest coastline of any US state.",
        "The world's smallest bird, the Cuban Bee Hummingbird, is found in Cuba.",
        "Brazil has more Portuguese speakers than Portugal.",
        "The world's longest swimming pool lies in Chile.",
        "Peru is famous for Machu Pichu.",
        "France is the world's most visited country.",
        "Germany invented gummy bears.",
        "The Vatican City is an enclave of Italy.",
        "Spain is home to the world's oldest restaurant, Sobrino de Botín.",
        "The Pol'and'Rock Festival is the largest free open-air music festival in the world.",
        "Norway is known for having the world's longest road tunnel.",
        "Albanian's shake their head for yes and nod for no.",
        "Austrailia has more kangaroos than people.",
        "Kiribati is the only country that lies in all four hemispheres."
    };

    public string CorrectAnswer { get; private set; }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }


    public void QuestionPicker()
    {
        answered = false;

        foreach (var ab in answerButtons)
        {
            ab.GetComponent<Image>().color = Color.white;
            ab.buttonText.fontStyle = FontStyles.Normal;
        } 

        int idx = Random.Range(0, questions.Count);
        questionText.text = questions[idx];
        factText.text = funFacts[idx];
        CorrectAnswer = correctAnswers[idx];
        questions.RemoveAt(idx);
        correctAnswers.RemoveAt(idx);
        funFacts.RemoveAt(idx);

        counter++;
        if (counter >= totalQuestions)
        {
            ss.End();
        }
    }

    public void AnswerChosen(string selectedAnswer)
    {
        if (answered)
        {
            return;
        }

        answered = true;

        foreach (answerButtonScript ab in answerButtons)
        {
            ab.GetComponent<Image>().color = Color.white;
            ab.buttonText.fontStyle = FontStyles.Normal;
        }

        foreach (answerButtonScript ab in answerButtons)
        {
            if (ab.buttonText.text == CorrectAnswer)
            {
                ab.GetComponent<Image>().color = new Color(0.6f, 1f, 0.6f);
               
            }

            if (ab.buttonText.text == selectedAnswer)
            {
                ab.buttonText.fontStyle = FontStyles.Bold;
                if (selectedAnswer != CorrectAnswer)
                {
                    wrongSound.Play();
                    str.ResetStreak();
                    str.UpdateStreak();
                    ab.GetComponent<Image>().color = new Color(1f, 0.4f, 0.4f, 1f);
                }
            }

            if (ab.buttonText.text == CorrectAnswer && selectedAnswer == CorrectAnswer)
            {
                correctSound.Play();
                str.IncreaseStreak();
                str.UpdateStreak();
                s.CorrectScore();
                s.UpdateScore();
                cs.AddCount();
                cs.UpdateCount();
            }
        } 
    }

    public void ForceAnswer()
    {
        answered = true;
        foreach (answerButtonScript ab in answerButtons)
        {
            ab.GetComponent<Image>().color = Color.white;
            ab.buttonText.fontStyle = FontStyles.Normal;

            if (ab.buttonText.text == CorrectAnswer)
            {
                ab.GetComponent<Image>().color = new Color(0.6f, 1f, 0.6f);
                ab.buttonText.fontStyle = FontStyles.Bold;
            }  
        }
    }

    public void ResetQuestions()
    {
        counter = 0;

        // this is reused from above

    questions = new List<string>()
    {
        "Which West African country is the most populous on the continent?",
        "Nairobi is the capital of which country?",
        "Which country is considered the origin of coffee?",
        "Which country is known for cocoa production?",
        "Which country is the most populous in the world?",
        "Where is the Ganges River located?",
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

    correctAnswers = new List<string>()
    {
        "Nigeria", "Kenya", "Ethiopia", "Ghana", "China", "India", "Japan", "Thailand",
        "Philippines", "Mongolia", "Bhutan", "United States", "Cuba", "Brazil", "Chile",
        "Peru", "France", "Germany", "Italy", "Spain", "Poland", "Norway", "Albania",
        "Austrailia", "Kiribati"
    };

    funFacts = new List<string>()
    {
        "Nigeria has the highest birth rate of twins.",
        "Kenya is famous for long-distance runners.",
        "Ethiopia was never colonized.",
        "The name Ghana means 'Warrior King'.",
        "Table tennis is China's national sport.",
        "India is the birthplace of chess.",
        "Slurping noodles is considered polite in Japan.",
        "Red Bull was inspired by a Thai energy drink.",
        "Karaoke is the national pastime of the Philippines.",
        "Mongolia is known for the Gobi Desert.",
        "Bhutan is home to the highest unclimbed mountain in the world.",
        "Alaska has the longest coastline of any US state.",
        "The world's smallest bird, the Cuban Bee Hummingbird, is found in Cuba.",
        "Brazil has more Portuguese speakers than Portugal.",
        "The world's longest swimming pool lies in Chile.",
        "Peru is famous for Machu Pichu.",
        "France is the world's most visited country.",
        "Germany invented gummy bears.",
        "The Vatican City is an enclave of Italy.",
        "Spain is home to the world's oldest restaurant, Sobrino de Botín.",
        "The Pol'and'Rock Festival is the largest free open-air music festival in the world.",
        "Norway is known for having the world's longest road tunnel.",
        "Albanians shake their heads for yes and nod for no.",
        "Austrailia has more kangaroos than people.",
        "Kiribati is the only country that lies in all four hemispheres."
    };

    }
}
