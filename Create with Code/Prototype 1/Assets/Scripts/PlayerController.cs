using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement tuning (editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed;

    // Input System action exposed in Inspector for binding (WASD/Arrow keys)
    public InputAction moveAction;
    
    // Current input value
    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the input action
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read the input value from the Input System
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Rotate the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
