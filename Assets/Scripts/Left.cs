
using System;
using UnityEngine;

public class Left : MonoBehaviour
{
    public bool left;

    
    
    private void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            left = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            left = true;
        }
               
    }

    private void OnTriggerExit(Collider col)
    {
        left = false;
    }

}
