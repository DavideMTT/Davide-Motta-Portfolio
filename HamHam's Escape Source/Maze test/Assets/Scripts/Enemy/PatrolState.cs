using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolState : BaseState
{

    public override void EnterState(NpcFSM npc)
    {
        base.EnterState(npc);

        Debug.Log("Entered Patrol State");

        agent.speed = patrolSpeed;
        SetDestination();
    }



    void SetDestination()
    {
        agent.destination = targets[FSM.targetIndex].position;

        //Debug.Log("Going to " + targets[targetIndex].transform.name);
        pMat.color = Color.green;

        FSM.StartCoroutine(patrolStatusCheck());
    }

    IEnumerator patrolStatusCheck()
    {
        yield return new WaitForSeconds(checkTime);

        if (agent.remainingDistance < distanceToTarget)
        {

            FSM.StartCoroutine(WaitThenChoose());
        }
        else if (Vector3.Distance(player.transform.position, FSM.NPCgO.transform.position) < chaseTriggerDistance)
        {
            FSM.MoveToState(FSM.s_Chase);
        }
        else
        {
            FSM.StartCoroutine(patrolStatusCheck());
        }



    }

    IEnumerator WaitThenChoose()
    {

        //Debug.Log("Choosing next target...");
        pMat.color = Color.cyan;


        yield return new WaitForSeconds(waitTime);
        NextDestination();
    }

    void NextDestination()
    {
        FSM.targetIndex += 1;

        if (FSM.targetIndex > FSM.targets.Count - 1)
        {
            FSM.targetIndex = 0;
        }

        SetDestination();
    }






}
