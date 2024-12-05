using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDog : MonoBehaviour
{
   [SerializeField] private int dogNumber;
   [SerializeField] private GameObject button1;
   [SerializeField] private GameObject button2;
   [SerializeField] private GameObject button3;
    void Start()
    {
        dogNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (dogNumber == 1)
            {
                button1.SetActive(false);
                button2.SetActive(true);
                button3.SetActive(true);
            }
            if (dogNumber == 2)
            {
                button1.SetActive(true);
                button2.SetActive(false);
                button3.SetActive(true);
            }
            if (dogNumber == 3)
            {
                button1.SetActive(true);
                button2.SetActive(true);
                button3.SetActive(false);
            }
        }
    }
    
}
