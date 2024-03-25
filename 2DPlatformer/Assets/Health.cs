using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    public int currentHealth;

    public delegate void OnTakeDamage(int damageAmount);
    public event OnTakeDamage onTakeDamage;

    public delegate void OnDeath();
    public event OnDeath onDeath;

    public HealthBar healthBar;

    private void Start()
    {
        //Initializes current health to max at the start of the game
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
    }

    //Method to take damage
    public void TakeDamage(int damageAmount)
    {
        //Reduce health by the damage amount;
        currentHealth -= damageAmount;

        //Invoke the OnTakeDamage Event
        onTakeDamage?.Invoke(damageAmount);

        healthBar.SetHealth(currentHealth);

        //Check if the health has reached zero or below
        if (currentHealth <= 0) 
        {
            onDeath?.Invoke();
        }
    }

    //Method to heal
    public void Heal(int healAmount)
    {
        currentHealth = Mathf.Min(currentHealth + healAmount, maxHealth);
    }

    public void fullHeal()
    {
        currentHealth = maxHealth;
    }

}
