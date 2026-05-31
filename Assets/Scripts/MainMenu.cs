using System;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Play Game");
    }

    public void Settings()
    {
        // Under construction
        Debug.Log("Settings Game"); 
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
