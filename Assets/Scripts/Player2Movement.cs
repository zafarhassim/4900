using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Movement : MonoBehaviour
{
    public Animator animator;
    public float walkMag = 0.01f;
    public bool isJumping = false;
    public AnimatorStateInfo Player1Layer0;
    public GameObject Player1;
    public GameObject Opponent;
    public Vector3 OppPosition;
    public int health = 100;
    public int currentHealth;

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


        if(SaveScript.p1h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }
        if (SaveScript3.p1h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }
        if (SaveScript3.p3h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }



        //Flip Character
        OppPosition = Opponent.transform.position;

        if (Input.GetKeyDown(KeyCode.P))
        {
            RotateByDegrees();
        }


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

          
        }

    }
    

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