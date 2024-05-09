using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPowerUp : MonoBehaviour
{
    public float timeToAdd = 15f;
    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Timer timer = FindObjectOfType<Timer>();
            if (timer != null)
            {
                audioManager.PlaySFX(audioManager.timeUp);
                timer.remainingTime += timeToAdd;
                Destroy(gameObject); // Destroy the pickup object after it's been picked up
            }
            else
            {
                Debug.LogWarning("Timer object not found in the scene.");
            }
        }
    }
}