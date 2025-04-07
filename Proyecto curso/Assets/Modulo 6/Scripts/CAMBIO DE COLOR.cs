using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIODECOLOR : MonoBehaviour
{
    public bool valor2 = false;
     bool falso = false;
     bool verdadero = true;
    private void Awake()
    {
        // Generar un color aleatorio usando Random.value
       // Color colorAleatorio = new Color(Random.value, Random.value, Random.value);

        // Obtener el MeshRenderer y cambiar el color del material
        //GetComponent<MeshRenderer>().material.color = colorAleatorio;

    }
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
        Renderer color = GetComponent<Renderer>();

        if (valor2 == true)
        {
            valor2 = falso;


            // Cambiar el color del material a blanco
            color.material.color = Color.black;
        }
        else if (valor2 == false)
        {
            valor2 = verdadero;
            color.material.color = Color.white;
        }
    }
}
