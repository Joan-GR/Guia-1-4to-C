using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaYProducto : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int resultado = 0;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log(resultado);
        resultado = num1 * num2;
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
