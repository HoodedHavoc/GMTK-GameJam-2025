using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRB;

    public float moveSpeed = 5.0f;
    Vector3 playerRot = Vector3.zero;

    public float maxYRot = 20f;
    public float minYRot = -20f;

    public Transform pointTo;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // Player continously moves forwards

        transform.LookAt(pointTo); // Player rotates towards object
    }

    private void FixedUpdate()
    {

    }

    private void OnSteering(InputValue inputValue)
    {
        // Rotate player using playerRot
        // Move player left or right based on delta value from mouse pointer (look up gamepad stick moving car)

        //Debug.Log(inputValue.Get<Vector2>());

    }
}
