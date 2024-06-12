using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovementAI : MonoBehaviour
{
    public Left script1;
    public Stop script4;
    public Front script2;
   [SerializeField] private GameObject _cat;
    public Right script3;
    private Vector3 _rot = new Vector3(0, 3, 0);
    private Vector3 _rot2 = new Vector3(0, -3, 0);
    void Update()
    {
        if (script1.left == true)
        {
            if (script2.front == false)
            {
                if (script3.right == false)
                { 
                    _cat.transform.Rotate(_rot2);
                }
            }
        }
        
        if (script1.left == false)
        {
            if (script2.front == false)
            {
                if (script3.right == true)
                { 
                    _cat.transform.Rotate(_rot);
                }
            }
        }
        
        
        
            if (script2.front == true)
            {
                if (script4.stop == false)
                {
                    _cat.transform.position += transform.forward * Time.deltaTime * 10;
                }
                
            }
        
    }
}
