using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class HelicoMovement : MonoBehaviour
{
   [SerializeField] private GameObject dog1;
   [SerializeField] private GameObject dog2;
   [SerializeField] private GameObject dog3;
   [SerializeField] public CharacterControllerScript dog;
   private float initialZRotation;
   private void Start()
   {
      initialZRotation = transform.eulerAngles.z;
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.R))
      {
         /*if (dog.dogNumber == 1)
         {
            dog1.SetActive(true);
         }

         if (dog.dogNumber == 2)
         {
            dog2.SetActive(true);
         }

         if (dog.dogNumber == 3)
         {
            dog3.SetActive(true);
         }*/
      }

      Move();
   }

   void Move()
   {
    
      
      if (transform.position.z < -0.09f)
         transform.position += new Vector3(0, 0, 5) * Time.deltaTime;
      
      if (transform.eulerAngles.y < initialZRotation + 45f)
      {
        
         transform.Rotate( new Vector3(0, 12.3f, 0) * Time.deltaTime);
      }
   }
}
