using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_Objetos_Andres : MonoBehaviour
{
    
    public GameObject HAmarilloPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")){
            Instantiate(HAmarilloPrefab);
        }

    }
}
