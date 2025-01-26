using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componente3 : MonoBehaviour
{
    private void Awake()
    {
<<<<<<< HEAD:Proyecto curso/Assets/Scenes/Scripts/componente3.cs
        Debug.Log("Hola Mundo en Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        componente1.miObjeto.name = "NuevoNombreDeObjeto";
        Debug.Log("Hola Mundo en Start");
=====
    }
    // Start is called before the first frame update
   
>>>>>>> origin/Practica-Modulo-5:Proyecto curso/Assets/Scenes/Scripts/Hola mundo.cs
    

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Hola Mundo en Update");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Hola Mundo en FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola Mundo en Late Update");
    }
}

