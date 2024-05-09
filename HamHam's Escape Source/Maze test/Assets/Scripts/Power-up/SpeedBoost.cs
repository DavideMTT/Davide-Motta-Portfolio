using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
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
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                audioManager.PlaySFX(audioManager.speedBoost);
                // Double the player's speed for 5 seconds.
                playerController.speed *= 2f;

                // Start a coroutine to revert the speed back to normal after 5 seconds.
                playerController.StartCoroutine(RevertSpeed(playerController));
            }

            Destroy(gameObject); // Destroy the pickup object
        }
    }

    IEnumerator RevertSpeed(PlayerController playerController)
    {
        yield return new WaitForSeconds(2f); // Wait for 5 seconds

        // Revert the player's speed back to normal.
        playerController.speed /= 2f;
    }
}