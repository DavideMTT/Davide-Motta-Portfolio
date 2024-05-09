using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacing : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        transform.LookAt(player.transform);

    }
}
