using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentScript : MonoBehaviour
{
    // Establishes the opponents health
    public int EnemyHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        // If the opponents health reaches 0 you win
        if (EnemyHealth == (0)) {
            Debug.Log("Test");
        }
    }
}
