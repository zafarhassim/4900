using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Actions : MonoBehaviour
{
    public float jumpMag = 0.01f;
   // public GameObject Player1;
    public Animator animator;
    public static bool Contact = false;
    public GameObject Opp;


    // Start is called before the first frame update
    void Start()

    {
        Opp = GameObject.Find("Player1");

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            animator.SetTrigger("KickOne");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetTrigger("KickTwo");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            animator.SetTrigger("PunchOne");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("PunchTwo");
            Contact = false;

        }
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Crouch");
            Contact = false;
        }
       
    }


}