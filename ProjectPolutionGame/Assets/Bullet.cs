using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Patrol patrol = hitInfo.GetComponent<Patrol>();
        FlyingEnemy bird = hitInfo.GetComponent<FlyingEnemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if (patrol != null)
        {
            patrol.TakeDamage(damage);
        }
        if (bird != null)
        {
            bird.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    



}
