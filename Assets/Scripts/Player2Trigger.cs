using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player2Trigger : MonoBehaviour
{
    public Collider collider;
    public float minusHealth = 0.1f;


    // Update is called once per frame
    void Update()
    {
        if (Player2Actions.Contact == false)
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
            Player2Actions.Contact = true;
            SaveScript.p1h -= minusHealth;

            
            
        }
       


    }
}
