using UnityEngine;
using UnityEngine.UI;

public class NewPlayerController : MonoBehaviour
{
    [Header("Vida")]
    public Slider healthBar;
    public Image healthFill;
    public int maxHealth = 100;

    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(other.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth = Mathf.Max(0, currentHealth - damage);
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        healthBar.value = currentHealth;
        healthFill.color = Color.Lerp(Color.red, Color.green, currentHealth / (float)maxHealth);
    }
}