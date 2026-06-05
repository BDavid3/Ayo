using System.Net;
using UnityEngine;

public class AudioTapeInteract : InteractBlueprint
{
    [SerializeField] private AudioSource tapeButtonAudio;
    protected override void OnInteract()
    {
        if (IsInteract)
        {
            // Nothing
        }
        else
        {
            tapeButtonAudio.Stop();
        }
    }
}
