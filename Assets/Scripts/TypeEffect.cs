using System.Collections;
using TMPro;
using UnityEngine;

public class TelephoneUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private float typingSpeed;
    [TextArea] [SerializeField] private string fullText;
    
    void Start()
    {
        dialogText.text = "";
        StartCoroutine(TypeText());
    }
    IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            dialogText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
