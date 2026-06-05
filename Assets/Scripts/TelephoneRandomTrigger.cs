using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class TelephoneRandomTrigger : MonoBehaviour
{
    [SerializeField] private TelephoneInteract telephoneInteractScript;
    private AudioSource _audioSource;
    private bool _didItHit;
    
    void Start()
    {
        telephoneInteractScript.enabled = false;
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(HittingChance());
    }

    public void Restart()
    {
        telephoneInteractScript.enabled = false;
        StartCoroutine(HittingChance());
    }

    IEnumerator HittingChance()
    {
        while (true)
        {
            int randomNumber = Random.Range(0, 10000000);
            
            if (randomNumber == 0)
            {
                telephoneInteractScript.enabled = true;
                _audioSource.Play();
                yield break; // Exits Coroutine
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
