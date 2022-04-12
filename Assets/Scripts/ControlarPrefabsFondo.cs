using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarPrefabsFondo : MonoBehaviour
{
    int controlador=0;
    int guardaVariable=1;
    public float posEliminacion;   
    GameObject inicialA2;
    //para crear
    public GameObject unoa2;
    public GameObject dosa3;
    public GameObject unoa3;
    //Para eliminar
    GameObject unoa2e;
    GameObject dosa3e;
    GameObject unoa3e;
    
    public float px;
    public float py;

    //banderas
    int bandera1a2=0;
    int bandera1a3=0;  
    int bandera2a3=0;
    int randomAnterior;
    // Start is called before the first frame update          
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (guardaVariable == 1)
        {
            inicialA2 = GameObject.Find("inicialA2");
            if(inicialA2.transform.position.y<=posEliminacion)      
            {
                Debug.Log(inicialA2.transform.position);
                Destroy(inicialA2);
                guardaVariable=2;
                controlador = Random.Range(2,4);
                crearFondoNew();
            }
        }
        if (guardaVariable == 2)
        {
            unoa2e = GameObject.Find("unoa2");
            if(unoa2e.transform.position.y <= posEliminacion)        
            {
                Destroy(unoa2e);
                guardaVariable=3;
                //for para que el anterior no sea igual al nuevo
                for (int i=0; i<20; i++)
                {       
                    if(controlador == randomAnterior)
                    {
                        controlador = Random.Range(1,4);
                    }
                    else
                    {
                        i = 22;
                    }
                }
                crearFondoNew();
            }
        }
        if (guardaVariable == 3)
        {
            elimanarobojeto();
        }
    }  
    void  elimanarobojeto()
    {
        if (bandera1a2 == 1)
        {
            unoa2e = GameObject.Find("unoa2(Clone)");
            if(unoa2e.transform.position.y <= posEliminacion)
            {
                
                for (int i=0; i<20; i++)
                {
                    if(controlador == randomAnterior)
                    {
                        controlador = Random.Range(1,4);
                    }
                    else
                    {
                        i = 22;
                    }   
                }   
                Destroy(unoa2e);
                bandera1a2=0;
                crearFondoNew();
            }
        }
        if (bandera1a3 == 1)
        {
            unoa3e = GameObject.Find("unoa3(Clone)");
            if(unoa3e.transform.position.y <= posEliminacion)
            {
                for (int i=0; i<20; i++)
                {
                    if(controlador == randomAnterior)
                    {
                        controlador = Random.Range(1,4);
                    }
                    else
                    {
                        i = 22;
                    }
            }
                Destroy(unoa3e);
                bandera1a3=0;
                crearFondoNew();
            }
        }
        if (bandera2a3 == 1)
        {
            dosa3e = GameObject.Find("dosa3(Clone)");
            if(dosa3e.transform.position.y <= posEliminacion)
            {
                for (int i=0; i<20; i++)
                {
                    if(controlador == randomAnterior)
                    {
                        controlador = Random.Range(1,4);
                    }
                    else
                    {
                        i = 22;
                    }
            }
                Destroy(dosa3e);
                bandera2a3=0;
                crearFondoNew();
            }
        }
    }
    void crearFondoNew()
    {
        Vector3 position = new Vector3(px,py,0);
        Quaternion rotation = new Quaternion();
                if (controlador == 1)
                {
                    Instantiate(unoa2,position,rotation);
                    bandera1a2 = 1;
                }
                if (controlador == 2)
                {
                    Instantiate(unoa3, position, rotation);     
                    bandera1a3 = 1;
                }
                if (controlador == 3)
                {
                    Instantiate(dosa3, position, rotation);   
                    bandera2a3 = 1;
                }
                randomAnterior = controlador;
    }
    
}
