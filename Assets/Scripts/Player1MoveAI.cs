using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1MoveAI : MonoBehaviour
{
    public Animator animator;
    public float walkMag = 0.01f;
    public bool isJumping = false;
    public AnimatorStateInfo Player1Layer0;
    public GameObject Player1;
    public GameObject Opponent;
    public Vector3 OppPosition;
    public bool FacingLeft = true;
    public bool FacingRight = false;
    public int health = 100;
    public int currentHealth;

    public float OppDist;
    public float AttDist = 1.5f;
    public bool MoveAI = true;
    public static bool AttState = false;

   // public Transform mtarget;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        currentHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
        Player1Layer0 = animator.GetCurrentAnimatorStateInfo(0);

        //OppDistance = Vector3.Distance(Opponent.transform.position, Player1.transform.position);

        //Flip Character
        OppPosition = Opponent.transform.position;

        if (Input.GetKeyDown(KeyCode.P))
        {
            RotateByDegrees();
        }
       // transform.LookAt.(mtarget.postion);
       // transform.Translate(0.0f, 0.0f, walkMag);
        /*
        //Horizontal Walking
        if (Player1Layer0.IsTag("Motion"))
        {
            if ((Input.GetAxis("HorizontalP2") > 0))
            {
                animator.SetBool("Forward", true);
                transform.Translate(0, 0, walkMag);
            }
            if ((Input.GetAxis("HorizontalP2") < 0))
            {
                animator.SetBool("Backward", true);
                transform.Translate(0, 0, -walkMag);

            }
            if (Input.GetAxis("HorizontalP2") == 0)
            {
                animator.SetBool("Backward", false);
                animator.SetBool("Forward", false);
            }

            //Jumping and crouching
            if (Input.GetAxis("VerticalP2") < 0)
            {
                if ((Input.GetAxis("VerticalP2") < 0))
                {
                    isJumping = true;
                    animator.SetTrigger("Jump");
                    StartCoroutine(JumpPause());
                }
            }
            if ((Input.GetAxis("VerticalP2") > 0))
            {
                animator.SetBool("Crouch", true);
            }
            if ((Input.GetAxis("VerticalP2") == 0))
            {
                animator.SetBool("Crouch", false);
            }
        */


    }

    /*
    IEnumerator JumpPause()
    {
        yield return new WaitForSeconds(1.0f);
        isJumping = false;

    }
    */

    void RotateByDegrees()
    {
        Vector3 rotationToAdd = new Vector3(0, 180, 0);
        transform.Rotate(rotationToAdd);
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Hit");
        currentHealth = health - 10;

    }

}
