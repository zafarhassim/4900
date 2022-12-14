using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Trigger : MonoBehaviour
{
    public Collider collider;
    public float minusHealth = 0.1f;


    // Update is called once per frame
    void Update()
    {
        if (Player3Actions.Contact == false)
        {
            collider.enabled = true;

        }
        else
        {
            collider.enabled = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Player3Actions.Contact = true;
            SaveScript3.p1h -= minusHealth;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            Player3Actions.Contact = true;
            SaveScript3.p2h -= minusHealth;
        }
       

    }
}
