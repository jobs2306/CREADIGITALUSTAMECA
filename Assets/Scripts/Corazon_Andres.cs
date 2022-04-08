using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazon_Andres : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        GameObject indicador = GameObject.Find("Andres Indicador de vida");
        indicador.GetComponent<Contadores_Obstaculos_Andres>().aumentarContadorCO(1);
        Destroy(gameObject);
    }
}
