using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRB;

    public float _moveSpeed = 5.0f;
    public float _rotationSpeed = 100.0f;

    public Transform _checkGround;
    public float _checkSphereRadius = 10;


    public Course courseStage;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();

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

        //courseStage.Attract(transform);

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime); // Player continously moves forwards

        if (Input.GetAxis("Horizontal") != 0) // if horizontal buttons A, D, Left Arrow or Right Arrow are pressed // Can be replaced with Input.GetAxis("Mouse X")
        {

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

        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 2.0f);
    }


}
