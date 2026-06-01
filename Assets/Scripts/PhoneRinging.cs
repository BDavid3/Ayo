using UnityEngine;

public class PhoneRinging : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _audioSource;
    private bool _IsRinging;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_IsRinging && Input.GetKeyDown(KeyCode.E))
        {
            StopRinging();
        }
    
    }

    public void StartRinging()
    {
        if (_IsRinging)
            return;
        _IsRinging = true;
        
        _animator.SetTrigger("StartRinging");
        _audioSource.Play();
        
        Debug.Log("Playing sound: " + _audioSource.clip); // add this
        
    }
    
    public void StopRinging()
    {
        if  (!_IsRinging)
            return;
        _IsRinging = false;
        
        _animator.SetTrigger("PickUp");
        _audioSource.Stop();
    }
}
