using UnityEngine;

[CreateAssetMenu(fileName = "DialogueLine", menuName = "Scriptable Objects/DialogueLine")]
public class DialogueLine : ScriptableObject
{
    public string characterName;
    [TextArea] public string text;
    public AudioClip audioClip;
}


