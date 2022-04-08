using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientojugador : MonoBehaviour
{
        public float velocidad = 10;
        Animator jugadoranim;
        SpriteRenderer jugadorRender;
        bool VoltearJugador;
        Rigidbody2D jugadorRB;
        float fuerzaSalto = 50f;
        int Limsaltos = 2;
        int saltosHechos = 0;

    void Start()
    {
        jugadorRB = GetComponent<Rigidbody2D>();
        jugadoranim = GetComponent<Animator>();
        jugadorRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Debug.Log(saltosHechos);
        float movimiento = Input.GetAxis("Horizontal");

        if (movimiento > 0 && !VoltearJugador)
        {
            Voltear();
        }
        else if (movimiento <0 && VoltearJugador)
        {
            Voltear();
        }
        jugadorRB.velocity = new Vector2(movimiento*velocidad, jugadorRB.velocity.y);
        jugadoranim.SetFloat("VelMovimiento",Mathf.Abs(movimiento));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (saltosHechos<Limsaltos)
            {
                jugadorRB.AddForce(new Vector2(0f,fuerzaSalto),ForceMode2D.Impulse);
                saltosHechos++;
            }
        }
    }

    void Voltear()
    {
        VoltearJugador = !VoltearJugador;
        jugadorRender.flipX = !jugadorRender.flipX;
    }
}
