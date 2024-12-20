using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDog : MonoBehaviour
{
    [SerializeField]private GameObject perso;
    [SerializeField]private GameObject mire;
    [SerializeField]private GameObject attackRange;
    [SerializeField]private GameObject attackRange1;
    // Start is called before the first frame update
    void Start()
    {
        mire.SetActive(false);
        attackRange1.SetActive(false);
        attackRange.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1)) 
        {
            mire.SetActive(true);
            perso.SetActive(false);
        }
        else
        {
            mire.SetActive(false);
            perso.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1)) 
        {
            attackRange1.SetActive(true);
            StartCoroutine(AttackWait1());
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackRange.SetActive(true);
            StartCoroutine(AttackWait());
            
        }
        
    }
    private IEnumerator AttackWait1()
    {

        yield return new WaitForSeconds(0.2f);
        attackRange1.SetActive(false);
    }
    private IEnumerator AttackWait()
    {

        yield return new WaitForSeconds(0.2f);
        attackRange.SetActive(false);
    }
}
