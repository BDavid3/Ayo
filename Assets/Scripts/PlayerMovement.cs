using UnityEngine;
using Cursor = UnityEngine.Cursor;

public class PlayerMovementScript : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody rb;
    public Transform cam;
    public Vector3 movement;
    
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float  h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;
        camForward.y = 0f;
        camRight.y = 0f;
        camForward.Normalize();
        camRight.Normalize();
        
        movement = (camForward * v + camRight * h);
        
        
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * (speed * Time.fixedDeltaTime));
    }
    
}
