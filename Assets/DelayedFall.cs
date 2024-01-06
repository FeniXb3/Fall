using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DelayedFall : MonoBehaviour
{
    public bool queued;
    public float delay = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            queued = false;
        }
    }

    public void QueueFall()
    {
        if (queued)
        {
            return;
        }

        queued = true;
        transform.DOShakeRotation(delay, 10, 10, 30, false, ShakeRandomnessMode.Harmonic).onComplete = Fall;
    }

    void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
