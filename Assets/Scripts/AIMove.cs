using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AIMove : MonoBehaviour
{
    // public Transform mtarget; 
    // Start is called before the first frame update
    //  public Transform mtarget;
 //   public GameObject Opp;
    // Adjust the speed for the application.
    public float speed = 1.0f;
    public Animator animatorAI;
    public GameObject Player1;
    public Vector3 OppPosition;
    public GameObject Opponent;
    public int health = 100;
    public int currentHealth;

    // The target (cylinder) position.
    public Transform target;

    void Awake()
    {
        // Position the cube at the origin.
      //  transform.position = new Vector3(0.0f, 0.0f, 0.0f);

      
    }

    void Start()
    {
        animatorAI = GetComponentInChildren<Animator>();
        OppPosition = Opponent.transform.position;
        Opponent = GameObject.Find("Player2");
        currentHealth = health;



    }

    void Update()
    {
       // Player1Layer0 = animatorAI.GetCurrentAnimatorStateInfo(0);

        // Move our position a step closer to the target.
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        animatorAI.SetBool("Forward", true);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            // Swap the position of the cylinder.
            target.position *= -1.0f;
        }

        
        if (OppPosition.x < Player1.transform.position.x)
        {
            RotateByDegrees();
            
        }
        else
        {
            RerotateByDegrees();
        }

        if (SaveScript.p2h <= 0)
        {
            SceneManager.LoadScene("MainMenu");

        }


    }
    void RotateByDegrees()
    {
        Vector3 rotationToAdd = new Vector3(0, 180, 0);
        transform.Rotate(rotationToAdd);
    }
    void RerotateByDegrees()
    {
        Vector3 rotationToAdd = new Vector3(0, -180, 0);
        transform.Rotate(rotationToAdd);
    }

    void OnTriggerEnter(Collider other)
    {
        animatorAI.SetTrigger("Hit");
        currentHealth = health - 10;

    }
}