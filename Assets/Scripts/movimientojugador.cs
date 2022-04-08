using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientojugador : MonoBehaviour
{
        public float velocidad = 10;
        bool puedeSaltar = false;
    
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown("left"))
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown("right"))
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown("up") && puedeSaltar)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400f));
            puedeSaltar = false;
        }
        gameObject.GetComponent<Transform>().Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * velocidad, 0, 0));
                   

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "suelo")
        {
            puedeSaltar = true;
        }
    }
}
