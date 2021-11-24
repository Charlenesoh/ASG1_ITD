using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // brings users to start playing with the AR Camera
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Quits the player from the application
    public void QuitGame()
    {
        Application.Quit();
    }

    // Leads player to quiz scene
    public void Quiz()
    {
        SceneManager.LoadScene("Quiz");
    }
}
