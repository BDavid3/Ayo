using System;
using UnityEngine;

public class MainInteractScript : MonoBehaviour
{
    [SerializeField] private Outline outlineScript;
    [SerializeField] private GameObject canvas;
    [SerializeField] private PlayerAndCameraMovement playerAndCameraMovementScript;
    private bool _isInteract;
    private bool _isInRange;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collider"))
        {
            outlineScript.enabled = true;
            _isInRange = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Collider"))
        {
            outlineScript.enabled = false;   
            _isInRange = false;
        }
    }

    private void Update()
    {
        if (_isInRange && Input.GetKeyDown(KeyCode.E))
        {
            _isInteract = !_isInteract;
            // Set True
         
            playerAndCameraMovementScript.enabled = !_isInteract;
            Cursor.visible = _isInteract;
            Cursor.lockState =  _isInteract ? CursorLockMode.None : CursorLockMode.Locked;
            canvas.SetActive(_isInteract);
            
        }
    }
}
