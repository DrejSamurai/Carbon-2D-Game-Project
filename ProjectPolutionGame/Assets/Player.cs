using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int maxOxygen = 100;
    public int currentHealth;
    public int currentOxygen;
    public int healAmountFromMedkit = 40;
    private GameMaster gm;
    public GameOver gameOver;

 
    public static int Lives = 3;
    bool canTakeDmg = true;
    bool oxygenDamage = true;

   
    
    public HealthBar healthbar;
    public OxygenBar oxygenBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentOxygen = maxOxygen;
        healthbar.SetMaxHealth(maxHealth);
        oxygenBar.SetMaxOxygen(maxOxygen);
        PlayerPrefs.GetInt("Lives");

        gm = GameObject.FindObjectOfType<GameMaster>();
        
        transform.position = gm.lastCheckPointPosition;
        

    }

    
    

    

    void DamageCheck(int amount, string type, Collision2D hitInfo, bool waitTime = true)
    {
        if (hitInfo.gameObject.tag == type)
        {
            if (canTakeDmg)
            {
                if(waitTime) StartCoroutine(WaitForSeconds());
                TakeDamage(amount);
                
            }
        }
        
    }

    void OxygenDamageCheck(string type, int amount, Collision2D hitInfo, bool waitTime = true)
    {
        if (hitInfo.gameObject.tag == type)
        {
            if (oxygenDamage)
            {
                if (waitTime) StartCoroutine(WaitForSeconds());
                OxygenDamage(amount);

            }
        }
    }

    void CollisionDetection(Collision2D hitInfo)
    {
        DamageCheck(10, "Enemy", hitInfo);
        DamageCheck(10, "EnemyPatrol", hitInfo);
        DamageCheck(15, "Flying Enemy", hitInfo);
        DamageCheck(100, "Instant Death", hitInfo, false);
        Death();
    }

   


    
    void OnCollisionStay2D(Collision2D hitInfo)
    {
        CollisionDetection(hitInfo);      
    }

    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        CollisionDetection(hitInfo);
       
        
    }
    


    IEnumerator WaitForSeconds()
    {
        canTakeDmg = false;
        yield return new WaitForSecondsRealtime(1);
        canTakeDmg = true;
    }

    IEnumerator WaitForOxygen()
    {
        oxygenDamage = false;
        yield return new WaitForSecondsRealtime(1);
        oxygenDamage = true;

    }

  
    void OxygenDamage(int amount)
    {
        currentOxygen -= amount;
        oxygenBar.SetOxygen(currentOxygen);
    }



    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    public void Death()
    {
        
       
        if (Lives == 0 )
        {
            PauseGame();
            gameOver.Setup();
            Lives = 3;
        }
        
        if (currentHealth <= 0)
        {
            
            PlayerPrefs.SetInt("Lives", --Lives);
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

   
    
    void PauseGame()
        {
      
            Time.timeScale = 0;
        }
    }
