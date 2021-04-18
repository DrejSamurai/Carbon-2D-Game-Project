using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    private GameMaster gm;
    
    public HealthBar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        gm = GameObject.FindObjectOfType<GameMaster>();
        transform.position = gm.lastCheckPointPosition;
    }


    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Enemy")
        {
            TakeDamage(10);
        }

        Death();
        

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    public void Death()
    {
        if (currentHealth == 0)
        {
            //Application.LoadLevel(Application.loadedLevel);          
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
