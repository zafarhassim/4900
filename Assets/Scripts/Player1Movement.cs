using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player1Movement : MonoBehaviour
{
    public Animator animator;
    public float walkMag = 0.01f;
    public bool isJumping = false;
    public AnimatorStateInfo Player1Layer0;
   // public GameObject Player1;
  //  public GameObject Opponent;
   // public Vector3 OppPosition;
    
    //public Player1HeathSystem player1HeathSystem;
    public int health = 100;
    public int currentHealth;

    void Awake()
    {
        currentHealth = health;

    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Player1Layer0 = animator.GetCurrentAnimatorStateInfo(0);

        if (SaveScript.p2h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }
        if (SaveScript3.p2h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }
        if (SaveScript3.p3h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }

        //Flip Character
        // OppPosition = Opponent.transform.position;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            RotateByDegrees();
        }


        //Horizontal Walking
        if (Player1Layer0.IsTag("Motion"))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("Forward", true);
                transform.Translate(0, 0, walkMag);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("Backward", true);
                transform.Translate(0, 0, -walkMag);

            }
            if (Input.GetAxis("Horizontal") == 0)
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
        currentHealth = health -10;
       // player1HeathSystem.takeDamage(damage);
    }

}