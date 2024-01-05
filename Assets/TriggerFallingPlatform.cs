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

        body.gameObject.GetComponent<DalayedFall>().QueueFall();

        // queued = true;
        // Debug.Log("OnControllerColliderHit");
        // DOVirtual.DelayedCall(3, () => body.useGravity = true);
        
        // body.useGravity = true;
        //body.gameObject.transform.DOMove(new Vector3(-5.53000021f,13.8900001f,15.3699999f), 20);
    }
}
