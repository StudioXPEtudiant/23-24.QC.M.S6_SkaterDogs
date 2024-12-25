using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    [SerializeField]public float rotationSpeedD = 0.5f;  
    [SerializeField]public float rotationSpeedN = 2;
    [SerializeField]private string dOUn;
    
   
    private void Start()
    {
      
    }

    void Update()
    {
        if (transform.eulerAngles.x < 181 & transform.eulerAngles.x > -179)
        {
            transform.Rotate(rotationSpeedD * Time.deltaTime, 0, 0);
            dOUn = "D";
            
        }
        else
        {
            transform.Rotate(rotationSpeedN * Time.deltaTime, 0, 0);
            dOUn = "N";
            
        }
        
       
    }
}
