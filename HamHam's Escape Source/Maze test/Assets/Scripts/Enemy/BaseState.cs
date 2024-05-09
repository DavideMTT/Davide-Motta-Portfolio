using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class BaseState
{
    #region Variables
    protected List<Transform> targets;
    protected int targetIndex;

    protected float waitTime;
    protected float checkTime;
    protected float distanceToTarget;

    protected NavMeshAgent agent;
    protected Material pMat;

    protected GameObject player;
    protected GameObject NPC;

    protected float chaseTriggerDistance;
    protected float chaseQuitDistance;

    protected NpcFSM FSM;
    protected MonoBehaviour mbParent;

    protected float chaseSpeed;
    protected float patrolSpeed;

    #endregion

    //Setting variables for all derivative states.
    public virtual void EnterState(NpcFSM npc)
    {
        targets = npc.targets;

        waitTime = npc.waitTime;
        checkTime = npc.checkTime;
        distanceToTarget = npc.distanceToTarget;

        agent = npc.agent;
        pMat = npc.pMat;

        NPC = npc.NPCgO;
        player = npc.player;
        chaseTriggerDistance = npc.chaseTriggerDistance;
        chaseQuitDistance = npc.chaseQuitDistance;

        FSM = npc;

        chaseSpeed = npc.NPCChaseSpeed;
        patrolSpeed = npc.NPCPatrolSpeed;

    }



}