using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Outline _outline;

    public void Start()
    {
        _outline = GetComponent<Outline>();
        _outline.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} entered");
        _outline.enabled = true;
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log($"{other.name} exited");
        _outline.enabled = false;
    }
}
