using System;
using UnityEngine;

public abstract class InteractBlueprint : MonoBehaviour
{
    [SerializeField] private Outline outlineScript;
    [SerializeField] protected GameObject canvas;
    [SerializeField] private PlayerAndCameraMovement playerAndCameraMovementScript;
    protected bool IsInteract;
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

    void Update()
    {
        if (_isInRange && Input.GetKeyDown(KeyCode.E))
        {
            IsInteract = !IsInteract;
            // Set True
         
            playerAndCameraMovementScript.enabled = !IsInteract;
            Cursor.visible = IsInteract;
            Cursor.lockState =  IsInteract ? CursorLockMode.None : CursorLockMode.Locked;
            canvas.SetActive(IsInteract);
            
            OnInteract();
        }
    }
    // What to do after enabling canvas
    protected abstract void OnInteract();
}
