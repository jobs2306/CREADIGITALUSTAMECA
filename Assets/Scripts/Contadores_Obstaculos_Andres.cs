using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contadores_Obstaculos_Andres : MonoBehaviour
{
    public GameObject barraVida;
    int contHA; //Contador hongos amarillos
    int contHR; //Contador hongos rojos
    int contTO; //Contador trampas osos
    int contTP; //Contador trampa petroleo
    float maxHealth;
    float minRange;
    float maxRange;
    void Start()
    {
        maxHealth = barraVida.transform.localScale.x;
        transform.position = new Vector3(barraVida.transform.position.x + (maxHealth)/2, barraVida.transform.position.y, 0);
        maxRange = barraVida.transform.position.x + (barraVida.transform.localScale.x)/2;
        minRange = maxRange -maxHealth;
    }
    
    public void aumentarContadorHA (int hA)
    {
        contHA += hA;
        if(transform.position.x < maxRange)
        {
            transform.position = new Vector3(transform.position.x + maxHealth*0.1f, transform.position.y, transform.position.z);
        }
        Debug.Log("Hongo amarillo " + contHA);
    }

    public void aumentarContadorHR (int hR)
    {
        contHR += hR;
        if(transform.position.x > minRange)
        {
            transform.position = new Vector3(transform.position.x - maxHealth*0.1f, transform.position.y, transform.position.z);
        }
        Debug.Log("Hongo Rojo " + contHR);
    }

    public void aumentarContadorTO (int tO)
    {
        contTO += tO;
        if(transform.position.x > minRange)
        {
            transform.position = new Vector3(transform.position.x - maxHealth*0.5f, transform.position.y, transform.position.z);
        }
        Debug.Log("Trampa oso " + contTO);
    }

    public void aumentarContadorTP (int tP)
    {
        contTP += tP;
        if(transform.position.x > minRange)
        {
            transform.position = new Vector3(transform.position.x - maxHealth*0.1f, transform.position.y, transform.position.z);
        }        
        Debug.Log("Trampa petroleo " + contTP);
    }
}
