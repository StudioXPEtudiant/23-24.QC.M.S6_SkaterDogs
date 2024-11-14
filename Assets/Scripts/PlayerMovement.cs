using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float walkSpeed;
    [SerializeField]private float jumpForce = 13f; 
    [SerializeField]private Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.LeftShift)) 
            transform.position += transform.forward * walkSpeed * Time.deltaTime;
        
        if(Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.LeftShift))
            transform.position -= transform.forward * walkSpeed * Time.deltaTime;
        
        if(Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.LeftShift)) 
            transform.position += transform.right * walkSpeed * Time.deltaTime;
        
        if(Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.LeftShift)) 
            transform.position -= transform.right * walkSpeed * Time.deltaTime;
        
        if(Input.GetKey(KeyCode.Space))
            Jump();
    }
    
    private void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    { 
  
        return Physics.Raycast(transform.position, Vector3.down, 2f);
 
    }


}
