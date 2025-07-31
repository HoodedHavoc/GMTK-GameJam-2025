using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRB;

    public float moveSpeed = 5.0f;

    //public Transform transformer;

    Vector3 playerRot = Vector3.zero;

    public float maxYRot = 20f;
    public float minYRot = -20f;

    //public Transform pointTo;

    Vector2 moveInput;

    private InputSystem_Actions playerInputActions;
    public float rotationSpeed = 100f; // Adjust as needed

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();

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
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // Player continously moves forwards

        Quaternion target = Quaternion.Euler(0, Input.GetAxis("Mouse X"), 0);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5.0f);


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
