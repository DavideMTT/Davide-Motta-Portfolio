using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollison : MonoBehaviour
{
    public float separationDistance = 2.0f; // Adjust this value as needed

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") // Check if the collision is with the player
        {
            Vector3 playerPosition = collision.collider.transform.position;
            float distance = Vector3.Distance(transform.position, playerPosition);

            if (distance < separationDistance)
            {
                Rigidbody rb = GetComponent<Rigidbody>();
                Vector3 separationDirection = (transform.position - playerPosition).normalized;
                rb.AddForce(separationDirection * 10.0f, ForceMode.Impulse); // Adjust the force as needed
            }
        }
    }
}
