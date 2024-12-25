using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private GameObject me;
   [SerializeField] private int health;
   [SerializeField] private int numberToDecrease;

    private void Start()
    {
        health = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
       // if (other.CompareTag("Cattack")) ;
       // {
            
           // StartCoroutine(AttackWait());
        //}
    }

    private void Update()
    {
        if (health < 0)
        {
            me.SetActive(false);
        }
    }

    [ContextMenu("Decrease")]
    public void Decrease()
    {
        health = health - numberToDecrease;
    }
    
    [ContextMenu("Die")]
    public void Die()
    {
        health = health - numberToDecrease;
    }
    
    private IEnumerator AttackWait()
    {
        Decrease();
        yield return new WaitForSeconds(0.3f);
        
    }
 }