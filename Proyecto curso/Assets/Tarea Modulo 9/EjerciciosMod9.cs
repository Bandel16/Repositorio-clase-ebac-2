using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosMod9 : MonoBehaviour
{ 
    //Actividad 1
    int[] arreglo1= new int[4];
    int[] arreglo2= new int[4];
    int[] arreglo3= new int[4];

    //Actividad 2
    string[] Frase= new string[7] {"I", "am", "thou", ",","Thou", "art","i"  };
    string oracioncompleta="";
    //Actividad 3
    int[,] Matriz=new int[2, 3] { {1,2,3 },{ 3,4,5} };
    int[] vector= new int[3] { 1, 2, 3 };
    int[] resultado = new int[2];
    // Start is called before the first frame update
    void Start()
    {
        //Actividad 1
        for (int i = 0; i < arreglo1.Length; i++) { 
            arreglo1 [i] = Random.Range(1,10);
            
        }
        for (int i = 0; i < arreglo2.Length; i++)
        {
            arreglo2[i] = Random.Range (10,20);
     
        }

        for(int i = 0; i < arreglo3.Length; i++)
        {
            arreglo3[i]= arreglo1[i]+arreglo2[i];
        }
        for (int i = 0; i < arreglo1.Length; i++)
        {
            Debug.Log(i + "\t" + arreglo1[i] + "\t" + arreglo2[i] + "\t" + arreglo3[i]);
        }

        //Actividad 2
        foreach (string palabra in Frase) {
            oracioncompleta += palabra+" ";
        }
        Debug.Log(oracioncompleta);
        //Actividad 3
        for (int i = 0; i <2; i++) {
            int suma = 0;
            
            
            for (int j = 0; j < 3; j++) {
                suma += (Matriz[i, j] * vector[j]);
               
            }
            resultado[i] += suma;
        }

        foreach(int i in resultado)
        {
            Debug.Log (i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
