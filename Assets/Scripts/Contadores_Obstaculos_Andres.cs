using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contadores_Obstaculos_Andres : MonoBehaviour
{
    
    int contHA; //Contador hongos amarillos
    int contHR; //Contador hongos rojos
    int contTO; //Contador trampas osos
    int contTP; //Contador trampa petroleo
    //GameObject maxHealth = GameObject.Find("LifeBar").GetProperty(localScale);
    float maxHealth = 20f; //tamaño de la barra de vida
    float minRange;
    float maxRange;
    void Start()
    {
        maxRange = transform.position.x;
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
