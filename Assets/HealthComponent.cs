using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    public int maxHealth = 100;
    public HP hp;

    // Start is called before the first frame update
    void Start()
    {
        hp.currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
