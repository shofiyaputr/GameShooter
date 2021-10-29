using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void Main()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Ke Menu");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Mulai Permainan");
    }

    public void Win()
    {
        SceneManager.LoadScene("Finish");
    }

    public void CaraBermain()
    {
        SceneManager.LoadScene("How to Play");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}
