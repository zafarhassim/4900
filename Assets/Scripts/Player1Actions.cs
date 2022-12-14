using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Actions : MonoBehaviour
{
    public float jumpMag = 0.01f;
    public GameObject Player1;
    public Animator animator;
    public static bool Contact = false;
    public GameObject Opp;
    
    // Start is called before the first frame update
    void Start()
    {
        Opp = GameObject.Find("Player2");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            animator.SetTrigger("KickOne");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("KickTwo");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("PunchOne");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("PunchTwo");
            Contact = false;

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Crouch");
            Contact = false;
        }



    }






}
