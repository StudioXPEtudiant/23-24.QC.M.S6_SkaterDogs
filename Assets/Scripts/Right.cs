
using System;
using UnityEngine;

public class Right : MonoBehaviour
{
    public bool right;

    private void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            right = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            right = true;
        }
               
    }

    private void OnTriggerExit(Collider col)
    {
        right = false;
    }

    

    


}
