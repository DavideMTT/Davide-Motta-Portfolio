using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Assuming PlayerController script is attached to the player object
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                // Assuming PlayerHealth script is attached to the player object
                PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
                Debug.Log("gotcomponent");

                if (playerHealth != null)
                {
                    // Assuming there's a method in PlayerHealth to increase health
                    playerHealth.IncreaseHealth(1);
                    Debug.Log("incweasing hp :3");

                    // Destroy the pickup object after picking it up
                    //Destroy(gameObject);
                }
                Destroy(gameObject);
            }
        }
        
    }
}


