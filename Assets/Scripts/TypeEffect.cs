using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private float typingSpeed;

    private int _index;

    public void StartTyping()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        dialogText.text = "";
        foreach (char c in dialogText.text)
        {
            dialogText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
} 
