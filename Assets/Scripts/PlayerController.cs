using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    //Rigidbody playerRB;
    CharacterController character;
    PlayerInput playerInput;

    public float _moveSpeed = 5.0f;
    public float _rotationSpeed = 100.0f;

    public Transform _checkGround;
    public float _checkSphereRadius = 10;


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
        //Cursor.lockState = CursorLockMode.Locked;

        //playerRB.constraints = RigidbodyConstraints.FreezeRotation;
        //playerRB.useGravity = false;

    }

    private void Update()
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

            RotatePlayer();
            
        }


        if (Physics.CheckSphere(_checkGround.transform.position, _checkSphereRadius))
        {
            //transform.rotation.y = Quaternion.FromToRotation(transform.up, Vector3.up);
        }


        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }*/
    }

    public void RotatePlayer()
    {

        transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0); // rotate player

        // Rotate Yaw when turning



        //Quaternion target = Quaternion.Euler(0, Input.GetAxis("Horizontal") * _rotationSpeed, 0);

    }*/
    


}

