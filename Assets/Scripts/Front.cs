
using System;
using UnityEngine;

public class Front : MonoBehaviour
{
    public bool front;

    private void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            front = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            front = true;
        }
               
    }

    private void OnTriggerExit(Collider col)
    {
        front = false;
    }
    

    
}
