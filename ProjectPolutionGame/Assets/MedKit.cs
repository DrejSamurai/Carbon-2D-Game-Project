using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    Player player;
    public HealthBar healthbar;

    public int healthBonus = 40;

    void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (player.currentHealth < player.maxHealth)
        {
          
            Destroy(gameObject);
            player.currentHealth += healthBonus;
            healthbar.SetHealth(player.currentHealth);

           
        }
    }
}
