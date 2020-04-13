using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour 
{
    //max health is set to 100
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    //health goes down after each left mouse click
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            TakeDamage(20);
        }
    }

    //the basic damage calculator 
    //will be replaced once enemies are in the game
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
