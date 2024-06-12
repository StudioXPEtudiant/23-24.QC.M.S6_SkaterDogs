
using System;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public bool stop;

    
    
    private void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            stop = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            stop = true;
        }
               
    }

    private void OnTriggerExit(Collider col)
    {
        stop = false;
    }

    

    
}
