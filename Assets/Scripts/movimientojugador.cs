using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientojugador : MonoBehaviour
{
    public float velocidad = 10;
    public float fuerzaSalto = 500f;
    bool puedeSaltar = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        rotar();
        saltar();
        desplazarse();        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "suelo")
        {
            puedeSaltar = true;
        }
    }

    private void rotar()
    {
        if (Input.GetKeyDown("left"))
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown("right"))
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void saltar()
    {
        if (Input.GetKeyDown("up") && puedeSaltar)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaSalto));
            puedeSaltar = false;
        }
        
         
    }

    private void desplazarse()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5, 0));
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 0));
        }
    }


}
