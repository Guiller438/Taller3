using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public void CambiarColor(Color nuevoColor)
    {
        // Obtener el componente Renderer del propio GameObject
        Renderer renderer = GetComponent<Renderer>();

        // Verificar si el objeto tiene un componente Renderer
        if (renderer != null)
        {
            // Cambiar el color del material del objeto al nuevo color especificado
            renderer.material.color = nuevoColor;
        }
        else
        {
            Debug.LogWarning("El objeto no tiene un componente Renderer. No se puede cambiar el color.");
        }
    }
}
