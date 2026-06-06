using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private PlayerMovement playerMovementScript;
    private bool _isActive;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isActive = !_isActive;
            
            pauseMenu.SetActive(_isActive);
            
            Cursor.lockState = _isActive ?  CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = _isActive;
            
            playerMovementScript.enabled = !_isActive;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
