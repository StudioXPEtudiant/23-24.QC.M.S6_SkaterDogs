using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLava : MonoBehaviour
{
    [SerializeField]private GameObject lava;
    [SerializeField]private GameObject UI;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lava.SetActive(false);
            UI.SetActive(false);
        }


    }
}
