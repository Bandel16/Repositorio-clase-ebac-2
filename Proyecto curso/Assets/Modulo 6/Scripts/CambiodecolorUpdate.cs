using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodecolorUpdate : MonoBehaviour
{
    public CambiodecolorFixedUpdate valor1;
    public CAMBIODECOLOR valor2;

    public bool resultado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Generar un color aleatorio usando Random.value
       // Color colorAleatorio = new Color(Random.value, Random.value, Random.value);

        // Obtener el MeshRenderer y cambiar el color del material
        //GetComponent<MeshRenderer>().material.color = colorAleatorio;
    }

    private void FixedUpdate()
    {
        Renderer color = GetComponent<Renderer>();

        if ((valor1.valor1 == true)&&(valor2.valor2 == true))
        {
            


            // Cambiar el color del material a blanco
            color.material.color = Color.white;
            resultado = true;
        }
        else { 
            
            color.material.color = Color.black;
            resultado = false;
        }
    }
}
