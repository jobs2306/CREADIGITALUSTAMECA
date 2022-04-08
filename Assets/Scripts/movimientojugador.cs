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
        transform.rotation = Quaternion.Euler(0,0,1.19f);
        if (Input.GetKeyDown("left"))
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown("right"))
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        
            gameObject.GetComponent<Transform>().Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * velocidad, 0, 0));
                   

    }


}
