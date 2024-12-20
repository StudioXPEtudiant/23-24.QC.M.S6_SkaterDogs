using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDog : MonoBehaviour
{
    [SerializeField]bool canChange;
    [SerializeField] private GameObject dog1;
    [SerializeField] private GameObject dog2;
    [SerializeField] private GameObject dog3;
    [SerializeField] private int dogSelect;
   [SerializeField] public int dogNumber;
   [SerializeField] private RectTransform button1;
   [SerializeField] private GameObject b1v1;
   [SerializeField] private GameObject b1v2;
   [SerializeField] private RectTransform button2;
   [SerializeField] private GameObject b2v1;
   [SerializeField] private GameObject b2v2;
   [SerializeField] private RectTransform button3;
   [SerializeField] private GameObject b3v1;
   [SerializeField] private GameObject b3v2;
    void Start()
    {
        dogNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {if(canChange){
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (dogNumber == 1)
            {
                b3v1.SetActive(true);
                b3v2.SetActive(false);
                b2v1.SetActive(false);
                b2v2.SetActive(true);
                dogSelect = 2;
            }
            if (dogNumber == 2)
            {
                b1v1.SetActive(true);
                b1v2.SetActive(false);
                b3v1.SetActive(false);
                b3v2.SetActive(true);
                dogSelect = 3;
            }
            if (dogNumber == 3)
            {
                b2v1.SetActive(true);
                b2v2.SetActive(false);
                b1v1.SetActive(false);
                b1v2.SetActive(true);
                dogSelect = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (dogNumber == 1)
            {
                b2v1.SetActive(true);
                b2v2.SetActive(false);
                b3v1.SetActive(false);
                b3v2.SetActive(true);
                dogSelect = 3;
            }

            if (dogNumber == 2)
            {
                b3v1.SetActive(true);
                b3v2.SetActive(false);
                b1v1.SetActive(false);
                b1v2.SetActive(true);
                dogSelect = 1;
            }

            if (dogNumber == 3)
            {
                b1v1.SetActive(true);
                b1v2.SetActive(false);
                b2v1.SetActive(false);
                b2v2.SetActive(true);
                dogSelect = 2;
            }
        }
    }
        
        
        
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            if (canChange)
            {
                dogNumber = dogSelect;

                if (dogNumber == 1)
                {
                    dog1.SetActive(true);
                }
                else
                {
                    dog1.SetActive(false);
                }

                if (dogNumber == 2)
                {
                    dog2.SetActive(true);
                }
                else
                {
                    dog2.SetActive(false);
                }

                if (dogNumber == 3)
                {
                    dog3.SetActive(true);
                }
                else
                {
                    dog3.SetActive(false);
                }

                canChange = false;
            }
        }
             
        if (Input.GetKeyDown(KeyCode.E))
        {
            canChange = true;
            b3v1.SetActive(true);
            b3v2.SetActive(false);
            b2v1.SetActive(true);
            b2v2.SetActive(false);
            b1v1.SetActive(true);
            b1v2.SetActive(false);
            if (dogNumber == 1)
            {
                button2.anchoredPosition = new Vector2(300, 0);
                button3.anchoredPosition = new Vector2(-300, 0);
            }
            if (dogNumber == 2)
            {
                button1.anchoredPosition = new Vector2(-300, 0);
                button3.anchoredPosition = new Vector2(300,0);
            }
            if (dogNumber == 3)
            {
                button1.anchoredPosition = new Vector2(300, 0);
                button2.anchoredPosition = new Vector2(-300,0);
            }
                 
                 
                 
            if (dogNumber == 1)
            {
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(true);
            }
            if (dogNumber == 2)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(false);
                button3.gameObject.SetActive(true);
            }
            if (dogNumber == 3)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(false);
            }
        }

      
    }
    
}
