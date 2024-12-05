using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   [SerializeField] private int health;
   [SerializeField] private int numberToDecrease;

    private void Start()
    {
        health = 100;
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
 }