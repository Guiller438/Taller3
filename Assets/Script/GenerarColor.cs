using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarColor : MonoBehaviour
{
    public Color CambiarColorRandom()
    {
        // Generar componentes de color aleatorios entre 0 y 1
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;

        return new Color(r, g, b);
        
        
    }
}
