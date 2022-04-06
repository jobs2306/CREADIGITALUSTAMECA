using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo_rojo_Andres : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        GameObject scripter = GameObject.Find("Scripter");
        scripter.GetComponent<Contadores_Obstaculos_Andres>().aumentarContadorHR(1);
        Destroy(gameObject);
    }

}
