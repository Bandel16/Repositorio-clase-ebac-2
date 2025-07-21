using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int n1 = 1,color=1;
    float n2=1f,operacion1=2.5f,operacion2=3.5f,resultado=0,Pi= 3.14159265f;
    Renderer Cylinder;
    string color2 = "Azul",nombre_completo="Angel Valdivieso Rodriguez";
    // Start is called before the first frame update
    void Start()
    {
        string resultado_Pi = Pi.ToString("F4");
        Cylinder = GetComponent<Renderer>();
        resultado = operacion1 + operacion2;
        int resultadoentero=(int)resultado;
        Debug.Log(resultadoentero);
        string nombre = nombre_completo.Substring(0,5);
        string apellido1=nombre_completo.Substring(6,11);
        string apellido2=nombre_completo.Substring(17);
        string[] partes = nombre_completo.Split(' ');

        switch (color2)
        {
            case "Rojo": Cylinder.material.color = Color.red;break;
            case "Azul": Cylinder.material.color = Color.blue;break;
            default: break;
        }
        Debug.Log(resultado_Pi);
        Debug.Log(nombre);
        Debug.Log(apellido1);
        Debug.Log(apellido2);
        for (int i = 0; i < partes.Length; i++)
        {
            Debug.Log(partes[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* n1 *= 2;
        Debug.Log(n1);*/
    }

    void FixedUpdate()
    {
       /*n2 *= 2.5f;
        Debug.Log(n2);*/

        //color++;
       /* if (color % 2 == 0)
        {
           Cylinder.material.color = Color.blue;
        }
        else {
            Cylinder.material.color = Color.red;
             }*/
        }
        
     
}
