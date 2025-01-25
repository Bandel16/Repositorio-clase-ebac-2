using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componente1 : MonoBehaviour
{
<<<<<<< HEAD:Proyecto curso/Assets/Scenes/Scripts/Hola mundo.cs
    private void Awake()
    {
        Debug.Log("Hola Mundo en Awake");
    }
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log("Hola Mundo en Start");
=======
    public static GameObject miObjeto;

    private void Awake()
    {
        miObjeto = this.gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
      
>>>>>>> 2963fce (Componentes):Proyecto curso/Assets/Scenes/Scripts/componente1.cs
    }

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

