using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerFallingPlatform : MonoBehaviour
{
    public bool queued;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.useGravity || queued)
        {
            return;
        }

        body.gameObject.GetComponent<DelayedFall>().QueueFall();
    }
}
