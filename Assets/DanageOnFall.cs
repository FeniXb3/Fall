using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DanageOnFall : MonoBehaviour
{
    public HP hp;
    public Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("OnControllerColliderHit");
        float heightDifference = lastPosition.y - transform.position.y;
        if (heightDifference > 3)
        {
            hp.currentHealth = 0;
        }

        lastPosition = transform.position;
    }
}
