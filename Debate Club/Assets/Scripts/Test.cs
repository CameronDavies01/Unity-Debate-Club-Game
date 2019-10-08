using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int EnemyHealth;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth = EnemyHealth - 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
