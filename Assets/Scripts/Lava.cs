using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lava : MonoBehaviour
{
    [SerializeField] private bool pop;
    public float growSpeed = 1.0f; 
    public Vector3 targetScale = new Vector3(4.0f, 4.0f, 4.0f);

    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
        pop = false;
    }

    void Update()
    {
        if (pop == false)
        {
            if (transform.localScale.x < targetScale.x)
            { 
                
                transform.localScale = Vector3.Lerp(transform.localScale, targetScale, growSpeed * Time.deltaTime);
            }
           
        }

        if (transform.localScale.x >= 5.8f)
        {
            pop = true;
            transform.localScale = Vector3.zero;
            StartCoroutine(Wait());
        }
        
       
    }

    IEnumerator Wait()
    {

        float waitTime = Random.Range(4f, 10f);

        yield return new WaitForSeconds(waitTime);
        
        pop = false;
    }
}