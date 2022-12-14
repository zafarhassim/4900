using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpAmount = 6;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Jump");

            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
    }
}
