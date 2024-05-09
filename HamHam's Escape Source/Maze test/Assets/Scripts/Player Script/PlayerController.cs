using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb; //declares the rigidbody of the object
    public float speed = 5.0f;//speed variable
    private Vector3 input;//variable of vector 3 which stores the input

    public float sinceLastFootsteps;
    public float timeBetweenFootSteps = 0.25f;


    AudioControl audioManager;
    public float soundDuration = 2.0f;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }


    void Update()
    {
        GatherInput();
        Look();
    }

    void FixedUpdate()
    {
        Move();
    }

    void GatherInput()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")); //recieve input from horizonral and vertical axis

    }

    void Look() //makes the hamster look at the direction the player is facing
    {
        if (input != Vector3.zero) //when no input is given , direction remains unchanged
        {
            var relative = (transform.position + input) - transform.position; //direction which the playe is facing
            var rot = Quaternion.LookRotation(relative, Vector3.up);
            transform.rotation = rot;// finding and applying the location
        }
    }

    void Move()
    {
        _rb.velocity = (transform.forward * input.magnitude) * speed * Time.deltaTime; //moves the player

        if (sinceLastFootsteps > timeBetweenFootSteps)
        {
            sinceLastFootsteps = 0f;
            audioManager.PlaySFX(audioManager.walking);
            Debug.Log("sound");
        }

    }
}
