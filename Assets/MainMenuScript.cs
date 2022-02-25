using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void PlayTheGame2()
    {
        SceneManager.LoadScene("Main-2");
    }

    public void PlayTheGame3()
    {
        SceneManager.LoadScene("Main-3");
    }

    public void QuitTheGame()
    {
        Debug.Log("Quit The Game");
        Application.Quit();
    }
}
