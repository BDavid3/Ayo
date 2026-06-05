using System;
using UnityEngine;

public class TapeButton : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ButtonPressed()
    {
        _audioSource.Play();
    }
}
