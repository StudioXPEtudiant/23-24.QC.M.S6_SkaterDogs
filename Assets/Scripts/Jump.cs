using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f; 
    public bool isGrounded = true;
    public Transform groundCheck; 
    public float groundDistance = 0.2f; 
    public LayerMask groundMask; 
    private Rigidbody rb;
    [SerializeField] private Transform player;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        float heightDifference = player.position.y - transform.position.y;
        if (heightDifference > 0.55 && isGrounded)
        {
            JumpAction();
        }
    }

    void JumpAction()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if(distanceToPlayer < 10) 
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
