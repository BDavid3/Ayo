using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicrophoneButton : MonoBehaviour
{
    
    private bool _isRecording;
    private AudioClip _audioClip;
    private List<AudioClip> _recordings = new List<AudioClip>();
    [SerializeField] private Image buttonImage;
    
    
    public void ButtonClicked()
    {
        if (!_isRecording)
        {
            _isRecording = true;
            buttonImage.color = Color.red;
            _audioClip = Microphone.Start(null, false, 3599, 44100);
        }
        else
        {
            _isRecording = false;
            buttonImage.color = Color.white;
            Microphone.End(null);

            _audioClip.name = "Recording" + (_recordings.Count + 1);
            _recordings.Add(_audioClip);
        }
        
    }
}
