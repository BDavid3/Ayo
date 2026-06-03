using UnityEngine;

public class HitBoxMovement : MonoBehaviour
{
    [SerializeField] private PlayerAndCameraMovement playerAndCameraMovement;

    void Update()
    {
        Quaternion targetRotation = Quaternion.Euler(playerAndCameraMovement.pitch, playerAndCameraMovement.yaw, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
    }
    
}
