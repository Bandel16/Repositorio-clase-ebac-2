using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;

    int valor1=5;
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if (variable1) {
            Debug.Log("Esta variable es verdadera");
            Debug.Log("Ya tienes el valor de la variable 1");
        }
        if (valor1<=5)
        {
            Debug.Log("El valor de la variable es menor o igual que 5");
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
