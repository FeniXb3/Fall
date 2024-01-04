using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformReseter : MonoBehaviour
{
    public Vector3 startingPositon;

    // Start is called before the first frame update
    void Start()
    {
        startingPositon = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log($"reset {name}");
            transform.position = startingPositon;
        }
    }
}
