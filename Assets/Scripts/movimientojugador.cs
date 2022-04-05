using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientojugador : MonoBehaviour
{
        public float velocidad = 10;
        public float velocidadSalto;
    
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetAxis("Horizontal") == -1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") == 1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        
            gameObject.GetComponent<Transform>().Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * velocidad, 0, 0));
                   

    }


}
