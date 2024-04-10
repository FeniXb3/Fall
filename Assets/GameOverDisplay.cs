using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDisplay : MonoBehaviour
{
    public HP hp;
    public Text label;
    // Start is called before the first frame update
    void Start()
    {
        label = GetComponent<Text>();
        label.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        label.enabled = hp.currentHealth <= 0;

        // if (hp.currentHealth <= 0)
        // {
        //     label.enabled = true;
        // }
        // else
        // {
        //     label.enabled = false;
        // }
    }
}
