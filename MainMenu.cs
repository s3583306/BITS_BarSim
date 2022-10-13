using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); // Enters Game
    }

    public void FeatureUnavailable()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2); // Feature Unavailable Message
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!"); // Log Message Quit
        Application.Quit(); // Quits Game
    }

    public void BackPrevious()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1); // Back to Previous Menu
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2); // Back to Main Menu
    }
}

