using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    float ToLookAround;


    void Start()
    {
        ToLookAround = Random.Range(5, 20);
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
            animator.SetBool("IsMoving", true);
        else
        {
            animator.SetBool("IsMoving", false);
            ToLookAround -= Time.deltaTime;
            if (ToLookAround < 0)
            {
                ToLookAround = Random.Range(5, 20);
                animator.SetTrigger("Look Around");
            }
        }
        if(Input.GetAxis("Sprint") > 0)
            animator.SetBool("IsSprinting", true);
        else
            animator.SetBool("IsSprinting", false);

    }
}
