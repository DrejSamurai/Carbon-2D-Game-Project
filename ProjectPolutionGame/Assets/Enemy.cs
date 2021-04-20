using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    
    public Animator animator;
    
    

    public void TakeDamage (int damage)
    {
        animator.SetBool("IsDead",false);
        health -= damage;

        if (health <= 0)
        {
            animator.SetBool("IsDead", true);
            
            Die();
        }
    }




    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);

        
        
        Destroy(gameObject,1);
        
    }
}
