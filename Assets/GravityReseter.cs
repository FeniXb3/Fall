using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReseter : MonoBehaviour
{
    Rigidbody body;
    public KeyCode resetKey;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            body.useGravity = false;
            body.isKinematic = true;
        }
    }
}
