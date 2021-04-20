using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool fire = false;


    
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (Input.GetButtonDown("Jump")) 
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            fire = true;
            animator.SetBool("IsShooting", true);
        }else if (Input.GetButtonUp("Fire1"))
        {
            fire = false;
            animator.SetBool("IsShooting", false);
        }
    }

    public void onLanding()
    {
        animator.SetBool("IsJumping", false);
        
    }

    public void switchToWalking()
    {
       animator.SetBool("IsShooting", false);
    }

    

    void FixedUpdate()
    {
        //Moving our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        fire = false;

    }

  
}
