using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Vida_Andres : MonoBehaviour
{   
    public GameObject indicadorVida;
    public GameObject anterior;
    int porcentajeVida;
    double[] rangos;
    double valorRango;
    // Start is called before the first frame update
    void Start()
    {
        indicadorVida = GameObject.Find("Andres_Indicador_de_vida");
        anterior = gameObject.transform.GetChild(1).gameObject; 
        rangos = new double[15];
        valorRango = 100.0/14.0;
        for (int i=0; i<14; i++)
        {
            rangos[i] = 100 - valorRango*i;
            Debug.Log(rangos[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
     porcentajeVida = indicadorVida.GetComponent<Contadores_Obstaculos_Andres>().porcentajeVida;
        if(porcentajeVida>=100)
        {
            
            GetComponent<SpriteRenderer>().enabled = true;
            gameObject.transform.GetChild(1).gameObject.SetActive(true); 
            gameObject.transform.GetChild(2).gameObject.SetActive(false); 
        }
        for (int i=0; i<13;i++)
        {
            if (porcentajeVida <= rangos[i])
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true); 
                anterior.gameObject.SetActive(false);
                anterior = gameObject.transform.GetChild(i).gameObject; 
            }
        }

    }
}
