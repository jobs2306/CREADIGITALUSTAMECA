using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_Objetos_Andres : MonoBehaviour
{
    
    public GameObject HAmarilloPrefab;
    public GameObject HRojoPrefab;
    public GameObject TPPrefab; //Prefab de petroleo
    public GameObject TOPrefab;//Trampa oso prefab
    public GameObject GAPrefab;//Gota agua prefab
    public GameObject COPrefab;//Corazon oso prefab
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")){ //cuando se oprime la letra entre comillas se crea el objeto referenciado con el Public GameObject.
            Instantiate(HAmarilloPrefab);
        }
        if (Input.GetKeyDown("o")){
            Instantiate(HRojoPrefab);
        }
        if (Input.GetKeyDown("i")){
            Instantiate(TOPrefab);
        }
        if (Input.GetKeyDown("l")){
            Instantiate(TPPrefab);
        }
        if (Input.GetKeyDown("k")){
            Instantiate(GAPrefab);
        }
        if (Input.GetKeyDown("j")){
            Instantiate(COPrefab);
        }

    }
}
