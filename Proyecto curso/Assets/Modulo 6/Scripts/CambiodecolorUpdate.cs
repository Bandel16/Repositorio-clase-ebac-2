using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodecolorUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Generar un color aleatorio usando Random.value
        Color colorAleatorio = new Color(Random.value, Random.value, Random.value);

        // Obtener el MeshRenderer y cambiar el color del material
        GetComponent<MeshRenderer>().material.color = colorAleatorio;
    }
}
