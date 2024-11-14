using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CatMovement : MonoBehaviour
{
 [SerializeField] private GameObject extendedSearchRange;
 [SerializeField]private float jumpForce = 5f; 
 [SerializeField]private Rigidbody rb;
 [SerializeField]public Transform player;
 [SerializeField]public float speed = 2f;
 private bool playerInBox;
 [SerializeField]public float Turnspeed = 5f;
 public float stopDistance = 1f;

 private void Start()
 {
  rb = GetComponent<Rigidbody>();
 }
 
 

 private void OnTriggerEnter(Collider other)
 {
  if (other.CompareTag("Player"))
  { 
   playerInBox = true;
  }
 }
 
 private void OnTriggerExit(Collider other)
 {
  if (other.CompareTag("Player"))
  { 
   playerInBox = false;
  }
 }

 private void Update()
 {
  
  if (playerInBox)
  {
   extendedSearchRange.SetActive(true);
  }
  else
  {
   extendedSearchRange.SetActive(false);
  }
  if (playerInBox)
  {
   Move();
  }
 }

 public void Move()
 {
  float distanceToPlayer = Vector3.Distance(transform.position, player.position);
           
  Vector3 direction = (player.position - transform.position).normalized;
  Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
  transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * Turnspeed);
           
           
  if (distanceToPlayer > stopDistance)
  {
   transform.position += transform.forward * speed * Time.deltaTime;
  }
 }
 
}
