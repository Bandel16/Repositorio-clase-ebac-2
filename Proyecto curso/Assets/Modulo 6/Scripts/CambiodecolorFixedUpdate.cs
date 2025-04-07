using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodecolorFixedUpdate : MonoBehaviour
{
    public bool valor1 = true;
     bool falso = false;
     bool verdadero = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Generar un color aleatorio usando Random.value
        //  Color colorAleatorio = new Color(Random.value, Random.value, Random.value);

        // Obtener el MeshRenderer y cambiar el color del material
        // GetComponent<MeshRenderer>().material.color = colorAleatorio;

        Renderer color = GetComponent<Renderer>();

        if (valor1 == true)
        {
            valor1 = falso;


            // Cambiar el color del material a blanco
            color.material.color = Color.black;
        }
        else if (valor1 == false)
        {
            valor1 = verdadero;
            color.material.color = Color.white;
        }
    }
}
