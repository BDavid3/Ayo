using UnityEngine;

public class PhoneTrigger : MonoBehaviour
{
    public PhoneRinging phone;
    
    void Start()
    {
        Debug.Log("PhoneTrigger is running");
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag ==  "Player")
        {
            phone.StartRinging();   
            Debug.Log("Triggered");
        }
    }
}
