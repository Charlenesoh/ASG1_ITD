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
        
    }

    void generateQuestions()
    {
        currentQuestions = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestions].Questions;
    }
}
