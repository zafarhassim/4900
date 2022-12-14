using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Actions : MonoBehaviour
{
    public float jumpMag = 0.01f;
   // public GameObject Player1;
    public Animator animator;
    public static bool Contact = false;
    public GameObject Opp;
    public GameObject Opp2;

    // Start is called before the first frame update
    void Start()

    {
        Opp = GameObject.Find("Player1");
        Opp2 = GameObject.Find("Player2");

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            animator.SetTrigger("KickOne");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            animator.SetTrigger("KickTwo");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            animator.SetTrigger("PunchOne");
            Contact = false;

        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            animator.SetTrigger("PunchTwo");
            Contact = false;

        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            animator.SetTrigger("Crouch");
            Contact = false;
        }

    }
}
