using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerFacing : MonoBehaviour
{
    public GameObject cat;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cat.transform);
    }
}
