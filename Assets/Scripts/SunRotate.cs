using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    public float rotationSpeedD = 0.7f;  
    public float rotationSpeedN = 1.2f;
    [SerializeField]private string dOUn;
    
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
