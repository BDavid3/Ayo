/*using UnityEngine;

public class NoteBook : MonoBehaviour
{
    public GameObject canvas;
    private Outline _outline;
    public bool isEnabled;

    [SerializeField] private PlayerMovementScript playerMovementScript;
    [SerializeField] private RotateCamera camScript;

    private void Start()
    {
        _outline = GetComponent<Outline>();
    }

    void Update()
    {
        if (_outline.enabled && Input.GetKeyDown(KeyCode.E))
        {
            isEnabled = !isEnabled;
            
            Cursor.visible = isEnabled;
            Cursor.lockState = isEnabled ? CursorLockMode.None : CursorLockMode.Locked;

            playerMovementScript.enabled = !isEnabled;
            camScript.enabled = !isEnabled;
            
            canvas.SetActive(isEnabled);
            
        }
    }
} */
