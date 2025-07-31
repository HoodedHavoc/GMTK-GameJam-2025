using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.Windows;

public class PointToObject : MonoBehaviour
{

    [SerializeField] private InputAction mouseInput;

    Vector3 mousePos;

    public Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //mousePos = Input.mousePosition;
    }

    private Vector3 currentMousePos;

    private void Awake()
    {
        //mouseInput.Enable();
        //mouseInput.performed += context => { currentMousePos = context.ReadValue<Vector2>(); };

        //cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Mouse.current.position.ReadValue();
        Vector3 pointToPos = new Vector3(mousePos.x, mousePos.y, 10f);

        transform.position = pointToPos;

        //Debug.Log(Mouse.current.position.ReadValue());
    }

    private void FixedUpdate()
    {
        
    }

    private void OnSteering(InputValue inputValue)
    {
        Vector2 screenPos = inputValue.Get<Vector2>();

        Vector3 camPos = new Vector3(screenPos.x, screenPos.y, cam.transform.position.y);
        mousePos = cam.ScreenToWorldPoint(camPos);

        //transform.position = Mouse.current.position.ReadValue();
        //Debug.Log(Mouse.current.position.ReadValue());
        Debug.Log(mousePos);
    }
}
