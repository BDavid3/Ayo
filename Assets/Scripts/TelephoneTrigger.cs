using System;
using UnityEngine;

public class PhoneTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource phoneAudio;
    [SerializeField]  private Outline outline;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            phoneAudio.Play();
            gameObject.SetActive(false);
            outline.enabled = true;
        }
    }
}
