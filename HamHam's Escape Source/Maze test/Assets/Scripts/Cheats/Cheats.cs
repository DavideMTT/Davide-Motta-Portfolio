using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private bool isTriggerOn = false;
    public float timeToAdd = 20f;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Timer timer = FindObjectOfType<Timer>();
        if (Input.GetKeyDown(KeyCode.C))  // when u press c turn on isTrigger and turn off collison detection
        {

            if (!isTriggerOn)
            {
                ChangeRigidbodyToTrigger();
                isTriggerOn = true;
                timer.remainingTime += timeToAdd; // basically the same concept of timerPowerup
            }
        }
        else if (Input.GetKeyDown(KeyCode.V))// basically the opposite for v
        {

            if (isTriggerOn)
            {
                ChangeRigidbodyToNonTrigger();
                isTriggerOn = false;
                timer.remainingTime -= timeToAdd;

            }
        }
        else if ( Input.GetKeyDown(KeyCode.X)) 
        
        {
          timer.remainingTime += timeToAdd;
        
        }
    }

    private void ChangeRigidbodyToTrigger()
    {

        playerRigidbody.detectCollisions = false;
    }

    private void ChangeRigidbodyToNonTrigger()
    {

        playerRigidbody.detectCollisions = true;
    }
}
