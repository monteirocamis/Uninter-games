using UnityEngine;
using System.Collections; 
using UnityEngine.UI;
using TMPro;
public class PlayerController : MonoBehaviour
{// Configuração manual da referência
    [Header("Configurações")]
    public Transform wandTip;
    public GameObject spellPrefab;

[Header("Movimento")]
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
//     private CharacterController charController;

    [Header("Vida")]
    public Slider healthBar;
    public Image healthFill;
    public int maxHealth = 100;
    private int currentHealth;

        [Header("Spell")]
    // public GameObject spellPrefab;
    // public Transform wandTip;


    public float spellForce = 15f;
    [Header("Debug")]
    public static PlayerController Instance;


    private CharacterController controller;
    private Camera mainCamera;
    public int health = 3;
public static PlayerController instance;
    void Start()
    {
        //charController = GetComponent<CharacterController>();
        currentHealth = maxHealth;
        UpdateHealthUI();
        
        controller = GetComponent<CharacterController>();
        mainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Awake()
    {
        Instance = this;
        Debug.Log("PlayerController inicializado!", this);
    }
    void Update()
    {
        //  HandleMovement();
        HandleShooting();
    void HandleShooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject spell = Instantiate(spellPrefab, wandTip.position, wandTip.rotation);
            spell.GetComponent<Rigidbody>().AddForce(wandTip.forward * spellForce, ForceMode.Impulse);
            Destroy(spell, 2f);
        }
    }
        // Movimento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * moveSpeed * Time.deltaTime);

        // Rotação com mouse
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);

        // Disparo
        // if (Input.GetButtonDown("Fire1"))
        // {
        //     CastSpell();
        // }
    }

    // void CastSpell()
    // {
    //     // Garante que a rotação está correta
    //     Quaternion spellRotation = wandTip.rotation;

    //     GameObject spell = Instantiate(spellPrefab, wandTip.position, spellRotation);

    //     Rigidbody rb = spell.GetComponent<Rigidbody>();
    //     if (rb != null)
    //     {
    //         // Aplica força na direção FORWARD da varinha
    //         rb.AddForce(wandTip.forward * spellForce, ForceMode.Impulse);
    //     }
    //     else
    //     {
    //         Debug.LogError("Feitiço não tem Rigidbody!");
    //     }

    //     Destroy(spell, 2f);
    // }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(other.gameObject);
            // health--;
            // Debug.Log("Vida: " + health);

            // // Efeito visual (piscar)
            // StartCoroutine(DamageEffect());

            // if (health <= 0) Die();
        }
    }
  void TakeDamage(int damage)
    {
        currentHealth = Mathf.Max(0, currentHealth - damage);
        UpdateHealthUI();
        
        // Debug de dano
        Debug.Log("Vida atual: " + currentHealth);
    }
      void UpdateHealthUI()
    {
        if (healthBar != null) healthBar.value = currentHealth;
        if (healthFill != null) 
            healthFill.color = Color.Lerp(Color.red, Color.green, currentHealth / (float)maxHealth);
    }



   IEnumerator DamageEffect()  
    {
        Renderer rend = GetComponent<Renderer>();
        Color original = rend.material.color;
        
        rend.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        rend.material.color = original;
    }
void Die()
{
    Debug.Log("Game Over!");
    //   lógica de reinício aqui
}

}