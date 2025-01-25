using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< HEAD:Proyecto curso/Assets/Scenes/Scripts/Holav.cs
public class Holav : MonoBehaviour
========
public class componente1 : MonoBehaviour
>>>>>>>> b580eb5 (Componentes):Proyecto curso/Assets/Scenes/Scripts/componente1.cs
{
<<<<<<< HEAD:Proyecto curso/Assets/Scenes/Scripts/Hola mundo.cs
    private void Awake()
    {
        Debug.Log("Hola en Awake");
    }
    // Start is called before the first frame update
    void Start()
<<<<<<<< HEAD:Proyecto curso/Assets/Scenes/Scripts/Holav.cs
    {
        Debug.Log("Hola en Start");
========
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
>>>>>>>> b580eb5 (Componentes):Proyecto curso/Assets/Scenes/Scripts/componente1.cs
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola en Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola en FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.LogError("Hola en LateUpdate");
    }
}
