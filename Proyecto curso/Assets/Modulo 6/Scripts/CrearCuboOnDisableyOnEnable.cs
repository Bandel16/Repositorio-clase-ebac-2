using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboOnDisableyOnEnable : MonoBehaviour
{
    public GameObject cuboPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Instantiate(cuboPrefab);
    }

    private void OnDisable()
    {
        Instantiate(cuboPrefab);
    }
}
