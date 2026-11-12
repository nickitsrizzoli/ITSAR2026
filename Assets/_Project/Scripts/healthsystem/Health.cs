using System;
using UnityEngine;


public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;
    float currentHealth;
    public float CurrentHealth => currentHealth;

public bool isDead {get;private set;}
public Action<float, float> OnHealChanged;
public Action Died;
    private void Awake()
    {
        currentHealth = maxHealth;
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log($"{currentHealth}/{maxHealth}"); //HP: 100/100 ES


        if(currentHealth <= 0)
        {
            Die();
        }
    }


    public void Heal(float heal)
    {
        currentHealth += heal;


        Mathf.Clamp(currentHealth, 0f, maxHealth);


       // if(currentHealth > maxHealth)
       // {
       //     currentHealth = maxHealth;
       // }


    }


    public void SetHealth(float _health, float _maxHealth)
    {
        currentHealth = _health;
        maxHealth = _maxHealth;
    }


    void Die()
    {
        isDead = true;
        Died.Invoke();
        gameObject.SetActive(false);
    }
}
