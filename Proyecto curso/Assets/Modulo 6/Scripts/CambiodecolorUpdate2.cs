using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodecolorUpdate2 : MonoBehaviour
{
    public CambiodecolorFixedUpdate valor1;
    public CAMBIODECOLOR valor2;

    public bool resultado2;
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

        if ((valor1.valor1 == true) || (valor2.valor2 == true))
        {



            // Cambiar el color del material a blanco
            color.material.color = Color.white;
            resultado2 = true;
        }
        else
        {

            color.material.color = Color.black;
            resultado2 = false;
        }
    }
}
