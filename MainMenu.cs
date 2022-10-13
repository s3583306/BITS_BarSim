using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //Moves from Main Menu to Game
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!"); //Quit Message in Log
        Application.Quit(); // Quits
    }
}
