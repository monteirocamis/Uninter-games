using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [Header("Referências")]
    [SerializeField] private Transform playerTarget; // Arraste o objeto da bruxinha aqui
    public GameObject[] ghostPrefabs;
    public float spawnRadius = 10f;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public int maxGhosts = 5;
    
    private float nextSpawnTime;
    private int currentGhostCount = 0;
       [Header("Referências")]
    [SerializeField] private Transform player;
    
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform;
            Debug.Log(player != null ? "Jogador encontrado automaticamente!" : "Jogador não encontrado");
        }
    }

    void Update()
    {
        if (ghostPrefabs == null || ghostPrefabs.Length == 0)
        {
            Debug.LogWarning("Nenhum prefab de fantasma atribuído!");
            return;
        }

        if (Time.time >= nextSpawnTime && currentGhostCount < maxGhosts)
        {
            SpawnGhost();
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }
        Debug.DrawLine(transform.position, playerTarget.position, Color.green);

    }
 
   void SpawnGhost()
    {
        if (player == null) return;
        
        Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
        spawnPos.y = 0;
        
        Quaternion rot = Quaternion.LookRotation(player.position - spawnPos);
        Instantiate(ghostPrefabs[Random.Range(0, ghostPrefabs.Length)], spawnPos, rot);
    }

    // void OnDrawGizmos()
    // {
    //     if (_debugSpawnArea)
    //     {
    //         Gizmos.color = Color.cyan;
    //         Gizmos.DrawWireSphere(transform.position, spawnRadius);
    //     }
    // }
}