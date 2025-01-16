using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private bool detectCat;
    [SerializeField]private GameObject me;
   [SerializeField] private int health;
   [SerializeField] private int numberToDecrease;

    private void Start()
    {
        health = 100;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cattacker")) ;
        {
            //Decreased();
        }
       
    }

    private void Update()
    {
        if (health < 0)
        {
            me.SetActive(false);
        }
    }

    [ContextMenu("Decrease")]
    public void Decreased()
    {
        detectCat = true;
        health = health - (numberToDecrease);
        StartCoroutine(AttackWait());
    }
    
    
    
    private IEnumerator AttackWait()
    {
        
        yield return new WaitForSecondsRealtime(0.3f);
        
    }
 }