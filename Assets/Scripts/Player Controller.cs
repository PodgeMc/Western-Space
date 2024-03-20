using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 2f;

    private Rigidbody rb;
    private Vector2 moveInput;
    private float rotateInput;

    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    private bool isFirstPerson = true; // Flag to track the current view mode

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Start with first person view active and third person view deactivated
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);
        rb.velocity = transform.TransformDirection(movement) * movementSpeed;
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, rotateInput * rotationSpeed);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRotate(InputValue value)
    {
        rotateInput = value.Get<float>();
    }

    public void ToggleView()
    {
        isFirstPerson = !isFirstPerson; // Toggle the view mode flag

        // Activate/deactivate cameras based on the view mode
        firstPersonCamera.enabled = isFirstPerson;
        thirdPersonCamera.enabled = !isFirstPerson;
    }
}
