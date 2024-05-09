using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Raycast : MonoBehaviour
{
    public LayerMask layermask;
    public Transform player;
    public float detectionRange = 10f;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 10f, layermask))
        {
            Debug.Log("Hit something!");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);
            transform.position = Vector3.MoveTowards(this.transform.position, player.position, 2 * Time.deltaTime);
            
        }
        else
        {
            Debug.Log("Hit nothing!");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10f, Color.green);
        }
        if (IsPlayerDetected())
        {
            StartChasingPlayer();
        }

    bool IsPlayerDetected()
    {
        // Perform raycast or other detection logic here
        RaycastHit hit;
        if (Physics.Raycast(transform.position, player.position - transform.position, out hit, detectionRange))
        {
                
                if (hit.collider.CompareTag("Player"))
            {
                    agent.SetDestination(player.position);
                    //return true;
            }
        }
        return false;
    }

    void StartChasingPlayer()
        {
            // Chasing the player
            Debug.Log("Chasing Player!");
            //agent.SetDestination(player.position);
        }

    }
}
