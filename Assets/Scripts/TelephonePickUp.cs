using System;
using UnityEngine;

public class TelephonePickUp : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    
    private AudioSource _audioSource;
    private Outline _outline;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _outline = GetComponent<Outline>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Collider") && Input.GetKeyDown(KeyCode.E))
        {
            _audioSource.Stop(); 
            _outline.enabled = false;
            canvas.enabled = true;
        }
    }
}
