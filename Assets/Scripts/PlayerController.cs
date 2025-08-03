using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    CharacterController character;
    PlayerInput playerInput;

    public bool _canMove = false;
    public float _moveSpeed = 5.0f;
    public float _rotationSpeed = 100.0f;


    float gravity = -9.8f, _verticalVelocity, mouseInput;
    public float sensitivity = 5f;

    private InputSystem_Actions playerInputActions;
    public float rotationSpeed = 100f; // Adjust as needed

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        //playerInput = new PlayerInput();

        //_canMove = false;


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {


        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }*/
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


        if (_canMove == true)
        {
            character.Move(new Vector3(0, _verticalVelocity, 0) * Time.deltaTime);
            character.Move(transform.forward * _moveSpeed * Time.deltaTime); // Player continously moves forwards

            mouseInput = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseInput);

            RotatePlayer();

        }

    }

    public void RotatePlayer()
    {

        transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0); // rotate player

        // Rotate Roll when turning



        //Quaternion target = Quaternion.Euler(0, Input.GetAxis("Horizontal") * _rotationSpeed, 0);

    }
    
     

}

