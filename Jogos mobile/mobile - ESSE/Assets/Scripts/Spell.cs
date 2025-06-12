using UnityEngine;

public class Spell : MonoBehaviour
{
    public int damage = 1;
    public GameObject hitEffect;


    void Update()
    {
        // Desenha uma linha vermelha mostrando a trajetória do feitiço
        Debug.DrawLine(transform.position, transform.position + transform.forward * 2, Color.red);
    }
    void OnTriggerEnter(Collider other)
    {
           if (other.CompareTag("Enemy"))
    {
        GameManager.Instance.AddScore(1); // +1 ponto
        Destroy(other.gameObject); // Destrói fantasma
        Destroy(gameObject); // Destrói feitiço
    }
    
        // Mostra todas as colisões (mesmo as que não são inimigos)
        Debug.Log($"Colisão detectada com: {other.name} (Tag: {other.tag})", other.gameObject);

        // Destaca o objeto colidido no Editor (mesmo que não seja inimigo)
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("ACERTOU INIMIGO!", other.gameObject);
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            Destroy(other.gameObject); // Destruição imediata para teste
            Destroy(gameObject);
        }
    }
    


    // void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("Feitiço colidiu com: " + other.name); // Verifique se aparece no Console
    //     if (other.CompareTag("Enemy"))
    //     {
    //         Debug.Log("Acertou inimigo!");
    //         // Restante do código...
    //     }



    // if (other.CompareTag("Enemy"))
    // {
    //     Enemy enemy = other.GetComponent<Enemy>();
    //     if (enemy != null)
    //     {
    //         enemy.TakeDamage(damage);

    //         // Efeito de purpurina
    //         if (hitEffect != null)
    //         {
    //             Instantiate(hitEffect, transform.position, Quaternion.identity);
    //         }

    //         Destroy(gameObject);
    //     }
    // }
}
