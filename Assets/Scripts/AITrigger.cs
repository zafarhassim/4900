using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrigger : MonoBehaviour
{
    public Collider collider;
    public float minusHealth = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (AIActions.HitReg == false)
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
            AIActions.HitReg = true;
            SaveScript.p2h -= minusHealth;


        }

    }
}
