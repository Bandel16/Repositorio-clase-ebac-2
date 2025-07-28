using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8Part2 : MonoBehaviour
{
    string numero1s = "1500", numero2s = "1700",frase="Hola Mundo",letras,frase2="Well excuse me princess";
    int numero1i, numero2i,resultado;
    // Start is called before the first frame update
    void Start()
    {
        bool num1=int.TryParse(numero1s,out numero1i);
        bool num2 = int.TryParse(numero2s, out numero2i);
        resultado=numero1i+numero2i;
        string letraseliminadas=frase2.Substring(05);
        Debug.Log(resultado);
        for (int i = 0; i < frase.Length; i++) {
            if (i % 2 == 0)
            {
                letras += frase[i];
            }
        }
        Debug.Log(letraseliminadas);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
