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
    int contGA; //Contador trampa petroleo
    int contCO; //Contador trampa petroleo
    //GameObject maxHealth = GameObject.Find("LifeBar").GetProperty(localScale);
    float maxHealth; //tamaño de la barra de vida
    float minRange;
    float maxRange;
    public int porcentajeVida;
    public float PosZ = -2;

    void Start()
    {
        maxHealth = barraVida.transform.localScale.x;
        transform.position = new Vector3(barraVida.transform.position.x + (maxHealth)/2, barraVida.transform.position.y, PosZ);
        maxRange = barraVida.transform.position.x + (barraVida.transform.localScale.x)/2;
        minRange = maxRange -maxHealth;
        porcentajeVida = 100;  
    }
    
    public void aumentarContadorHA (int hA)
    {
        contHA += hA;
        if(transform.position.x < maxRange)
        {
            transform.position = new Vector3(transform.position.x + maxHealth*0.1f, transform.position.y, PosZ);
            porcentajeVida +=10;
        }
        Debug.Log("Hongo amarillo " + contHA);
    }

    public void aumentarContadorHR (int hR)
    {
        contHR += hR;
        if(transform.position.x > minRange)
        {
            transform.position = new Vector3(transform.position.x - maxHealth*0.1f, transform.position.y, PosZ);
            porcentajeVida -=10;
        }
        Debug.Log("Hongo Rojo " + contHR);
    }

    public void aumentarContadorTO (int tO)
    {
        contTO += tO;
        if(transform.position.x > minRange)
        {
            transform.position = new Vector3(transform.position.x - maxHealth*0.5f, transform.position.y, PosZ);
            porcentajeVida = 50;
        }
        Debug.Log("Trampa oso " + contTO);
    }

    public void aumentarContadorTP (int tP)
    {
        contTP += tP;
        if(transform.position.x > minRange)
        {
            transform.position = new Vector3(transform.position.x - maxHealth*0.1f, transform.position.y, PosZ);
            porcentajeVida -=10;
        }        
        Debug.Log("Trampa petroleo " + contTP);
    }
    public void aumentarContadorCO (int cO)
    {
        contCO += cO;
        if(transform.position.x < maxRange)
        {
            transform.position = new Vector3(maxRange, transform.position.y, PosZ);
            porcentajeVida = 100;
        }        
        Debug.Log("Corazon oso " + contCO);
    }
    public void aumentarContadorGA (int gA)
    {
        contGA += gA;
        if(transform.position.x < maxRange)
        {
            transform.position = new Vector3(transform.position.x + maxHealth*0.1f, transform.position.y, PosZ);
            porcentajeVida +=10;
        }        
        Debug.Log("Trampa petroleo " + contTP);
    }
    
    void update()
    {
        if (porcentajeVida > 100)
        {
            porcentajeVida=100;
        }
        if(porcentajeVida<0)
        {
            porcentajeVida=0;
        }
    }
    
    public int getPorcentajeVida()
    {
        return porcentajeVida;
    }

}
