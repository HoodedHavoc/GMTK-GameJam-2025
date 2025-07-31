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
        
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // Player continously moves forwards

        transform.LookAt(new Vector3(pointTo.position.x, transform.position.y, pointTo.position.z)); // Player rotates towards object
    }
}
