using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIActions : MonoBehaviour
{
    public AnimatorStateInfo Player1Layer0;
    public Animator animator;
    public static bool HitReg = false;
    public int AttackNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          Player1Layer0 = animator.GetCurrentAnimatorStateInfo(0);

         if (Player1Layer0.IsTag("Motion"))
         {

            if (AttackNumber == 1)
            {
                animator.SetTrigger("KickOne");
                  HitReg = false;
            }
            if (AttackNumber == 2)
            {
                animator.SetTrigger("KickTwo");
                HitReg = false;
            }
            if (AttackNumber == 3)
            {
                animator.SetTrigger("PunchOne");
                HitReg = false;
            }
            if (AttackNumber == 4)
            {
                animator.SetTrigger("PunchTwo");
                HitReg = false;
            }
            if (AttackNumber == 5)
            {
                animator.SetTrigger("Crouch");
                HitReg = false;

            }
        }

         void RandomAttack()
        {
            AttackNumber = Random.Range(1, 6);
        }


    }
}
