using UnityEngine;

public class StarterScript : MonoBehaviour
{
    // Disable All Outlines

    void Start()
    {
        Outline[] outlines = FindObjectsByType<Outline>(FindObjectsSortMode.None);
        
        foreach (Outline outline in outlines)
        {
            outline.enabled = false;
        }
    }
}
