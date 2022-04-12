using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa_Oso_Andres : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        GameObject indicador = GameObject.Find("Andres_Indicador_de_vida");
        indicador.GetComponent<Contadores_Obstaculos_Andres>().aumentarContadorTO(1);
        Destroy(gameObject);
    }

}
