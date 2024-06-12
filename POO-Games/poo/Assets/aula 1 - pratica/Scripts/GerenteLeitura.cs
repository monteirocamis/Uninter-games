using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteLeitura : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void LerPalpite(string entrada)
    {
        int palpite;
        int.TryParse(entrada, out palpite);

    }
}
