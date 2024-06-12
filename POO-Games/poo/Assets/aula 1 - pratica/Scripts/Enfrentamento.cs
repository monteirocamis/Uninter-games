using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enfrentamento : MonoBehaviour
{

    void Start()
    {
        string[] nomes = { "a", "b", "c" };
        // nomes[1]

        int tamanho = nomes.Length;
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = i + 1; j < tamanho) ; j++{

                Debug.Log(nomes[i] + "x" + nomes[j]);

            }
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
