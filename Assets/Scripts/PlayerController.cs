using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    //Rigidbody playerRB;
    CharacterController character;
    PlayerInput playerInput;

    public float moveSpeed = 5.0f;

    //public Transform transformer;

    Vector3 playerRot = Vector3.zero;

    public float maxYRot = 20f;
    public float minYRot = -20f;

    //public Transform pointTo;



    float gravity = -9.8f, _verticalVelocity, mouseInput;
    public float sensitivity = 5f;

    private InputSystem_Actions playerInputActions;
    public float rotationSpeed = 100f; // Adjust as needed

    private void Awake()
    {
        //playerRB = GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
        playerInput = new PlayerInput();

        //playerInputActions = new InputSystem_Actions();
        //playerInputActions.Player.Enable(); // Enable the Player action map
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        if (character.isGrounded)
        {
            _verticalVelocity = -5f;
        }
        else
        {
            _verticalVelocity = _verticalVelocity + gravity * Time.deltaTime;
        }
        
        character.Move(new Vector3(0, _verticalVelocity,0) * Time.deltaTime);
        character.Move(transform.forward * moveSpeed * Time.deltaTime); // Player continously moves forwards

        mouseInput = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseInput);


        //transform.LookAt(new Vector3(pointTo.position.x, transform.position.y, pointTo.position.z)); // Player rotates towards object
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    /*public void onSteering(InputValue inputValue)
    {
        moveInput = inputValue.Get<Vector2>(); // Get value of input from WASD

        Vector3 direction = new Vector3(moveInput.x, moveInput.y); // Convert the vector values into a Vector3


    }*/
    


}

