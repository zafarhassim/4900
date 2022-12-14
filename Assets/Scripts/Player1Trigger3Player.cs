using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Trigger3Player : MonoBehaviour

{
    public Collider collider;
    public float minusHealth = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Player1Actions.Contact == false)
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
        if (other.gameObject.CompareTag("Player2"))
        {
            Player1Actions.Contact = true;
            SaveScript3.p2h -= minusHealth;
        }
        if (other.gameObject.CompareTag("Player3"))
        {
            Player1Actions.Contact = true;
            SaveScript3.p3h -= minusHealth;
        }
    }
}


