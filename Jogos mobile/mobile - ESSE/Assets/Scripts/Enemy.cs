using UnityEngine;

public class Enemy : MonoBehaviour
{ public delegate void DeathEvent();
    public event DeathEvent OnDeath;
    public int maxHealth = 1;
    public int points = 10;
    public GameObject deathEffect;
    
    private int currentHealth;
    private GameManager gameManager;

    void Start()
    {
        currentHealth = maxHealth;
        gameManager = FindObjectOfType<GameManager>();
    }
 void OnTriggerEnter(Collider other)
    {
        // Desaparece se encostar na bruxinha OU levar tiro
        if (other.CompareTag("Player") || other.CompareTag("Spell"))
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("Fantasma atingiu a bruxinha!");
        // Adicione dano ao player ou efeito aqui
    }
}

    void Die()
    {
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
        
        if (gameManager != null)
        {
            gameManager.AddScore(points);
        }
        
        Destroy(gameObject);
    }
}