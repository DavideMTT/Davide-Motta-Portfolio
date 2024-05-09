using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public static bool key;

    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }
    void Start()
    {
        key = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            audioManager.PlaySFX(audioManager.keyPickup);
            key = true;
            gameObject.SetActive(false);
            //Destroy(gameObject);

        }
    }
    void Update()
    {
        
    }
}
