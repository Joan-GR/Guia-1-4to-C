using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float montoFinal;
    float cotizacionMonedaElegida;
    // Start is called before the first frame update
    void Start()
    {
        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (codigoMoneda == "D")
        { 
            cotizacionMonedaElegida = 1075.20f;
            
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = 181.78f;
            
        }
        else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = 1176.43f;
            
        }
        else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }

        montoFinal = montoAConvertir / cotizacionMonedaElegida;

        Debug.Log(montoFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
