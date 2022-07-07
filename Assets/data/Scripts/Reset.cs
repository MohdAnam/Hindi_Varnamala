using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void ResetCliked()
    {
        SceneManager.LoadScene("HindiScene");
    }
    public void Card()
    {
        SceneManager.LoadScene("Card&Cube");
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void QuitApp()
    {
        Application.Quit();
    }

}
