using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola Mundo en Awake");
    }
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log("Hola Mundo en Start");
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

