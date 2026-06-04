using UnityEngine;
using System.Collections;

public class TelephoneRandomTrigger : MonoBehaviour
{
    private AudioSource _audioSource;
    private bool _didItHit;
    private MainInteractScript _mainInteractScript;
    
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _mainInteractScript = GetComponent<MainInteractScript>();
        _mainInteractScript.enabled = false;
        StartCoroutine(HittingChance());
    }

    IEnumerator HittingChance()
    {
        while (true)
        {
            int randomNumber = Random.Range(0, 10);
            
            if (randomNumber == 0)
            {
                _mainInteractScript.enabled = true;
                _audioSource.Play();
                break;
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
