using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEffect : MonoBehaviour
{

    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController playerController = FindAnyObjectByType<PlayerController>();

            if (playerController != null)
            {
                audioManager.PlaySFX(audioManager.trap);
                playerController.speed /= 5f;

                playerController.StartCoroutine(RevertSpeed(playerController));

            }

            Destroy(gameObject);
        }
    }
    

    IEnumerator RevertSpeed(PlayerController playerController)
    {
        yield return new WaitForSeconds(2f);
        playerController.speed *= 5f;
    }
}
