using System;
using UnityEngine;

public class TelephoneInteract : InteractBlueprint
{
    [SerializeField] private TypeEffect typeEffectScript;

    private AudioSource _audioSource;
    private TelephoneRandomTrigger _telephoneRandomTriggerScript;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _telephoneRandomTriggerScript = GetComponent<TelephoneRandomTrigger>();
    }

    protected override void OnInteract()
    {
        if (IsInteract)
        {
            typeEffectScript.enabled = true;
            _audioSource.Stop();
            typeEffectScript.TextCleanUp();
        }
        else
        {
            _telephoneRandomTriggerScript.Restart();
        }
    }
}
