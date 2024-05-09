using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Vector3 respawnPosition; //where the player should respawn

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TeleportPlayer();
        }
    }

    public void TeleportPlayer()
    {
        transform.position = respawnPosition; //move the hamster to the respawnPosition
    }
}
