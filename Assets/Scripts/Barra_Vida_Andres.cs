using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Vida_Andres : MonoBehaviour
{   
    public GameObject indicadorVida;
    int porcentajeVida;
    // Start is called before the first frame update
    void Start()
    {
        indicadorVida = GameObject.Find("Andres_Indicador_vida");
    }

    // Update is called once per frame
    void Update()
    {
        porcentajeVida = indicadorVida.GetComponent<Contadores_Obstaculos_Andres>().getPorcentajeVida();
        if(porcentajeVida>=100)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            for (int i = 0; i < 12; i++) 
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        if(porcentajeVida<=0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            for (int i = 0; i < 12; i++) 
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
                gameObject.transform.GetChild(11).gameObject.SetActive(true);
            }
        }
    }
}
