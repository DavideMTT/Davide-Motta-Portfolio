using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public static bool key;

    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "Player" )

        {
           // KeyScript.key = true;
            //If player has key
            if (KeyScript.key)
            {
                audioManager.PlaySFX(audioManager.door);
                Destroy(gameObject);

            }

        }
        
        
        
        
        /*
         //If player doesn't has the key
        if (collision.gameObject.tag == "Player")
        {
            isCollect = false;
        }
        */
    }
}
