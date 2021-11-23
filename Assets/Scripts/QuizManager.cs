using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestions;

    public Text QuestionTxt;

    private void Start()
    {
        generateQuestions();
    }


    public void Correct()
    {
        QnA.RemoveAt(currentQuestions);
        generateQuestions();
    }
    void SetAnswers()
    {
        for ( int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestions].Answers[i];

            if (QnA[currentQuestions].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }

        }
    }

    void generateQuestions()
    {
        currentQuestions = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestions].Questions;

        SetAnswers();

        
    }
}
