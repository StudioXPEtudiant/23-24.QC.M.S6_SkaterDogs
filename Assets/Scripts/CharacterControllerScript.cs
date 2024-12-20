
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerScript : MonoBehaviour
{
   [SerializeField] public ChangeDog dog;
    [SerializeField] private int dogChangeNumber;
    public Camera playerCamera;
    [SerializeField] public float walkSpeed = 6f;
    [SerializeField] public float runSpeed = 12f;
    [SerializeField] public float jumpPower = 7f;
    public float gravity = 5f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    [SerializeField] public float defultHight = 2f;
    

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;

    private bool canMove = true;

    void Start()
    {
        walkSpeed = 6f;
        runSpeed = 12f;
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    { 
        if (dog.dogNumber==1)
        {
            characterController.height = 2.8f;
            characterController.radius = 0.5f;
            characterController.center = new Vector3(0f, 0.55f, 0f);
            jumpPower = 10;
            walkSpeed = 10;
            runSpeed = 20;
        } 
        if (dog.dogNumber==2)
        {
            characterController.height = 3.3f; 
            characterController.radius = 0.7f;
            characterController.center = new Vector3(0f, 0.85f, 0f);
            jumpPower = 15;
            walkSpeed = 6;
            runSpeed = 12;
        }
   
        if (dog.dogNumber==3)
        {
            characterController.height = 3.85f;
            characterController.radius = 1f;
            characterController.center = new Vector3(0f, 1.1f, 0f);
            jumpPower = 10;
            walkSpeed = 4;
            runSpeed = 8;
}

Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }


        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
   
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    
    }
        
}