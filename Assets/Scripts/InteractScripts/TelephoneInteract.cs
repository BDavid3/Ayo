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
            _audioSource.Stop();
            typeEffectScript.enabled = true;
            typeEffectScript.StartTyping();
        }
        else
        {
            _telephoneRandomTriggerScript.Restart();
        }
    }
}
