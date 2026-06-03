using System;
using UnityEngine;

public class TelephonePickUp : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Collider") && Input.GetKeyDown(KeyCode.E))
        {
            _audioSource.Stop();           
        }
    }
}
