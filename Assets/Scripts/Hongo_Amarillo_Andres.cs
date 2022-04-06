using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo_Amarillo_Andres : MonoBehaviour
{
    int CoL_H_Amarillo = 0 ;
    
    private void OnTriggerEnter2D(Collider2D other) {
        CoL_H_Amarillo= CoL_H_Amarillo + 1;
        Debug.Log(CoL_H_Amarillo);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
