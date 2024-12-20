using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthCat : MonoBehaviour
{
    [SerializeField] CatPointsFunction die;
    // Start is called before the first frame update
    [SerializeField] private int health;
    [SerializeField] private int numberToDecreaseChing;
    [SerializeField] private int numberToDecreasePtiou;
    
    [SerializeField]private GameObject skin1;

    void Start()
    {
        
        health = 100;
    }
    
    
    void Update()
    {
        if ( health <1) 
        {
           die.Die();
           health = 100;
        }
    }

   private void OnTriggerEnter(Collider other)
    {
        
        
        if(other.CompareTag("AttackRangeChing"))
        {
            health = health - numberToDecreaseChing;
        }
        if(other.CompareTag("AttackRangePtiou"))
        {
            health = health - numberToDecreasePtiou;
        }
        if(other.CompareTag("AttackRangeChing"))
        {
            
            skin1.SetActive(true);
            StartCoroutine(SkinActive());
        }
        if(other.CompareTag("AttackRangePtiou"))
        {
            
            skin1.SetActive(true);
            StartCoroutine(SkinActive());
        }
    }

   IEnumerator SkinActive()
   {
       
       yield return new WaitForSeconds(0.5f);

       skin1.SetActive(false);
   }
}
