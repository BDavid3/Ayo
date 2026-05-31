using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
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
