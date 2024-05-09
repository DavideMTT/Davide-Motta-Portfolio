using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcFSM : MonoBehaviour

{
    #region Variables
    private BaseState currentState;
    public BaseState CurrentState
    {
        get { return currentState; }
    }

    [Header("States")]
    public PatrolState s_Patrol = new PatrolState();
    public ChaseState s_Chase = new ChaseState();

    [Header("Targets")]
    public List<Transform> targets;
    public int targetIndex;

    [Header("Moving variables")]
    public float waitTime;
    public float checkTime;
    public float distanceToTarget;

    public float chaseTriggerDistance;
    public float chaseQuitDistance;

    public float NPCChaseSpeed;
    public float NPCPatrolSpeed;

    [HideInInspector]
    public NavMeshAgent agent;
    [HideInInspector]
    public Material pMat;

    [HideInInspector]
    public GameObject player;
    [HideInInspector]
    public GameObject NPCgO;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        pMat = GetComponent<MeshRenderer>().material;

        NPCgO = this.gameObject;
        player = GameObject.FindGameObjectWithTag("Player");

        MoveToState(s_Patrol);
    }

    public void MoveToState(BaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
