using System;
using UnityEngine;

public class PhoneTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource phoneAudio;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            phoneAudio.Play();
            gameObject.SetActive(false);
        }
    }
}
