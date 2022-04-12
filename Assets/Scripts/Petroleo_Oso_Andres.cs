using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petroleo_Oso_Andres : MonoBehaviour
{
    float timer;
    public bool touching= false;
    int counter;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        touching=true;
        
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        touching=false;
        
    }
    void Update()
    {
        if (touching)
        {
            timer += Time.deltaTime;
            if(timer>1f)
            {
                //reducir la vida del osito
                GameObject indicador = GameObject.Find("Andres_Indicador_de_vida");
        indicador.GetComponent<Contadores_Obstaculos_Andres>().aumentarContadorTP(1);
                //counter += 1;
                //Debug.Log("Trampa de petroleo" + counter);

                timer=0;
            }
        }
    }
}
