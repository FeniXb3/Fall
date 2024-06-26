using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DalayedFall : MonoBehaviour
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
        
    }

    public void QueueFall()
    {
        if (queued)
        {
            return;
        }

        DOVirtual.DelayedCall(delay, Fall);
    }

    void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
