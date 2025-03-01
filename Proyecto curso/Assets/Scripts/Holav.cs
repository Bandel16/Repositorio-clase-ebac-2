using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Holav : MonoBehaviour
{

   

    private void Awake()
    {
        Debug.Log("Hola en Awake");
      
    }
   
    void Start()

    {
        Debug.Log("Hola en Start");

    }

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
        Debug.LogError("Hola en LateUpdate.");
    }
}
