using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Vida_Andres : MonoBehaviour
{   
    GameObject indicadorVida;
    GameObject anterior;
    int porcentajeVida;
    int porcentajeVidaAnterior;
    double[] rangos;
    double valorRango;
    // Start is called before the first frame update
    void Start()
    {
        anterior = gameObject.transform.GetChild(0).gameObject;
        anterior.SetActive(true);
        indicadorVida = GameObject.Find("Andres_Indicador_de_vida");
        porcentajeVidaAnterior = indicadorVida.GetComponent<Contadores_Obstaculos_Andres>().porcentajeVida;
        rangos = new double[14];
        valorRango = 100.0/14.0;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        //for (int i=0; i<=13; i++)
        //{
        //    rangos[i] = 100 - valorRango*i;
        //    Debug.Log(rangos[i]);
        //}
        //for (int i = 0; i <= 12; i++)   //De 0 a 12 hay 13 posiciones, igual al numero de recursos porque van del 1 al 14 saltandose el 3
        //{
        //    Debug.Log(gameObject.transform.GetChild(i).name);
        //}

    }

    // Update is called once per frame
    void Update()
    {
     porcentajeVida = indicadorVida.GetComponent<Contadores_Obstaculos_Andres>().porcentajeVida;
        if(porcentajeVida>=100)
        {
           //anterior.GetComponent<SpriteRenderer>().enabled = true;
           gameObject.transform.GetChild(0).gameObject.SetActive(true); 
           //gameObject.transform.GetChild(2).gameObject.SetActive(false); 
        }
        if (porcentajeVida != porcentajeVidaAnterior)
        {
            porcentajeVidaAnterior = porcentajeVida;
            for (int i = 0; i <= 12; i++)
            {
                if (porcentajeVida >= rangos[i])
                {
                    gameObject.transform.GetChild(i).gameObject.SetActive(true);
                    anterior.SetActive(false);
                    anterior = gameObject.transform.GetChild(i).gameObject;
                    break;
                }
            }
        }
    }
}
