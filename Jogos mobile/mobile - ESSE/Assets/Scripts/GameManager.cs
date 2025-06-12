using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    // public int points;
public static GameManager Instance;

    public static GameManager instance;
        [Header("UI")]
    [SerializeField] private TMP_Text scoreText;
    private int score;
 


   // public int score { get; private set; }
    public int currentLevel = 1;
    public int scoreToNextLevel = 100;


//sistema de pontos 
      [Header("Vida")]
[SerializeField] private int maxHealth = 100;
    private int currentHealth;
  [SerializeField] private Slider HealthBar;
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(10); // Dano por colisão
            Destroy(other.gameObject); // Destrói o fantasma
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);
        UpdateHealthBar();
        
        if (currentHealth <= 0) Die();
    }

    void UpdateHealthBar()
    {
        HealthBar.value = currentHealth;
    }

    void Die()
    {
        Debug.Log("Game Over!");
        // Adicione efeitos ou reinício
    }








    private void Awake()
    {  Instance = this;

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
          score += points;
        scoreText.text = $"{score}";
       // Debug.Log("Score: " + score);

      //  Verificar se avançou de nível
        if (score >= scoreToNextLevel)
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        currentLevel++;

        // Ajustar dificuldade
        scoreToNextLevel = currentLevel * 150;

        // Carregar próxima cena
        if (currentLevel <= 4)
        {
            SceneManager.LoadScene("Level" + currentLevel);
        }
        else
        {
            Debug.Log("Você venceu o jogo!");
            // Tela de vitória
        }
    }

 




    // public void AddPoints(int point)
    // {
    //     points += point;
    // }
    // + 1 points quando spel enconsta no ghost


}
  

//     // Update is called once per frame
//     void Update()
//     {
//         //debug teste
//         if (Input.GetKeyDown(KeyCode.P))
//         {
//             AddPoints(2);
//     }
//     }
//    
// }
