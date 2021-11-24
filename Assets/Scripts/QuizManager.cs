using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestions;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestion = 0;
    public int score;

    public GameObject quizPanel;
    public GameObject GameOverPanel;

    private void Start()
    {
        totalQuestion = QnA.Count;
        GameOverPanel.SetActive(false);
        generateQuestions();
    }

    public void restart()
    {
        SceneManager.LoadScene("Quiz");
    }

    void GameOver()
    {
        quizPanel.SetActive(false);
        GameOverPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestion;
    }

    public void Correct()
    {
        score += 1; 
        QnA.RemoveAt(currentQuestions);
        generateQuestions();
    }

    public void wrong()
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

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void generateQuestions()
    {
        if (QnA.Count > 0)
        {
        currentQuestions = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestions].Questions;

        SetAnswers();

        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
        
    }
}
