using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class RocketMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private Vector2 movement; // Movement direction

    void Start()
    {
        // Get the Rigidbody2D component attached to this GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from keyboard
        //movement.x = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) ? 1 : Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ? -1 : 0; // Right and Left
        //movement.y = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ? -1 : 0; // Up and Down

        // If there's movement, rotate to face the opposite direction
        if (movement != Vector2.zero)
        {
            RotatePlayer();
        }
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void RotatePlayer()
    {
        // Calculate the angle based on movement direction (inverted)
        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg + 0f; // Adjust for 2D sprite orientation
        rb.rotation = angle; // Set the rotation
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    public void MoveInput(Vector2 value)
    {
        movement = value;
    }
}
