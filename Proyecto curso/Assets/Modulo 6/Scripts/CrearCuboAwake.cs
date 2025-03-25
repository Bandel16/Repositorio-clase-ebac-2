using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
    public GameObject cuboPrefab;
  

    private void Awake()
    {
      Instantiate(cuboPrefab);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
