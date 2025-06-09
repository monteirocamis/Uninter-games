using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyReference;
    public float spawnTime = 1.5f;
    void Start()
    {
        StartCoroutine(AutoEnemyGenerator());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        CreateEnemy();
        }
    }

    void CreateEnemy(){
    Instantiate(EnemyReference, transform.position, Quaternion.identity);
    }

    // private IEnumerator WaitAndPrint(float waitTime);{
    // print("Coroutine ended: "+ Time.time + "second");
    // }
    private IEnumerator AutoEnemyGenerator(){
        while(true)
        {
            CreateEnemy();
            yield return new WaitForSeconds(spawnTime);
                    
        }

    }
}
