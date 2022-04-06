using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_Objetos_Andres : MonoBehaviour
{
    
    public GameObject HAmarilloPrefab;
    public GameObject HRojoPrefab;
    public GameObject Petroleo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")){ //cuando se oprime la letra entre comillas se crea el objeto referenciado con el Public GameObject.
            Instantiate(HAmarilloPrefab);
        }
        if (Input.GetKeyDown("o")){
            Instantiate(HRojoPrefab);
        }

    }
}
