using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private ScrollRect ScrollRect;
    [SerializeField] private float typingSpeed;
    [TextArea] [SerializeField] private string fullText;

    private void Start()
    {
        text.text = "";
        StartCoroutine(TypeText());
    }
    private IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            text.text += c;
            Canvas.ForceUpdateCanvases();
            ScrollRect.verticalNormalizedPosition = 0;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
