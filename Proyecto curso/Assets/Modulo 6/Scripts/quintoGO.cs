using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quintoGO : MonoBehaviour
{
    public CambiodecolorUpdate resultado;
    public CambiodecolorUpdate2 resultado2;
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

        if ((resultado.resultado == true) || (resultado2.resultado2 == true))
        {
            // Cambiar el color del material a blanco
            color.material.color = Color.white;
        }

        else
        {

            color.material.color = Color.black;

        }
    }
}
