using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contadores_Obstaculos_Andres : MonoBehaviour
{
    
    int contHA; //Contador hongos amarillos
    int contHR; //Contador hongos rojos
    
    public void aumentarContadorHA (int hA)
    {
        contHA += hA;
        Debug.Log(contHA);
    }

    public void aumentarContadorHR (int hR)
    {
        contHR += hR;
        Debug.Log(contHR);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
