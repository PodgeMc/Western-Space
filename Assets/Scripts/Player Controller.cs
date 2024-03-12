using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 2f;

    private Rigidbody rb;
    private Vector2 moveInput;
    private float rotateInput;
    private Camera activeCamera; // Reference to the active camera

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        activeCamera = Camera.main; // Start with the main camera
    }

    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);
        rb.velocity = transform.TransformDirection(movement) * movementSpeed; // Apply movement relative to player's rotation
    }

    void Rotate()
    {
        // Rotate the player
        transform.Rotate(Vector3.up, rotateInput * rotationSpeed);

        // Rotate the active camera
        if (activeCamera != null)
        {
            float mouseY = Mouse.current.delta.y.ReadValue(); // Get vertical mouse movement
            activeCamera.transform.Rotate(-mouseY, 0f, 0f); // Rotate camera vertically
        }
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRotate(InputValue value)
    {
        rotateInput = value.Get<float>();
    }

    public void SetActiveCamera(Camera camera)
    {
        activeCamera = camera;
    }
}
