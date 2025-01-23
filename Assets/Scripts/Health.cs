using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject lava;
    [SerializeField] private GameObject red;
    [SerializeField] private GameObject yellow;
    [SerializeField] private GameObject green;
    [SerializeField] private GameObject white;
    [SerializeField] private Slider slider;
    [SerializeField]private bool detectCat;
    [SerializeField]private GameObject me;
   [SerializeField] public int health;
   [SerializeField] private int numberToDecrease;

    private void Start()
    {
        health = 100;
    }

   
   
    private void Update()
    {
        
        slider.value = health;
        if (health < 0)
        {
            me.transform.position = new Vector3(0, 4, 0);
                health=100;
        }
        
        if (slider.value < 16)
        {
            red.SetActive(true);
        }
        else
        {
            red.SetActive(false);
        }
        
        if (slider.value < 51 && slider.value > 15)
        {
            yellow.SetActive(true);
        }
        else
        {
            yellow.SetActive(false);
        }
        if (slider.value < 100 && slider.value > 50)
        {
            green.SetActive(true);
        }
        else
        {
            green.SetActive(false);
        }
        if (slider.value == 100)
        {
            white.SetActive(true);
        }
        else
        {
            white.SetActive(false);
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