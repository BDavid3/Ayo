using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float sens = 20f;
    public Transform target;
    public float height = 2f;
    public float distance = 3f;

    public float yaw;
    public float pitch;

    private void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, -30f, 60f);

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);
        Vector3 offset = rotation * new Vector3(0f, height, -distance);

        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}