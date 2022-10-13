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

    public void QuitGame()
    {
        Debug.Log("QUIT!"); // Quit Game Log Message
        Application.Quit(); // Quit Game
    }

    public void BackPrevious()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1); // Back to previous Menu
    }
}

