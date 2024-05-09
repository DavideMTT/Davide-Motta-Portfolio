using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLocationChanger : MonoBehaviour
{

    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UpdateTeleportLocation(other.transform.position); //changes teleport location
        }
    }

    private void UpdateTeleportLocation(Vector3 newLocation)
    {
        PlayerTeleport playerTeleportScript = FindObjectOfType<PlayerTeleport>();//calling the PlayerTeleport scripy
        if (playerTeleportScript != null)
        {
            playerTeleportScript.respawnPosition = newLocation; // change the location
        }
    }
}
