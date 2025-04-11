using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class RocketMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private Vector2 movement; // Movement direction
    float moveVelocity;
    private bool left;
    private bool right;
    private bool up;
    private bool down;

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

        //Left Right Movement
        if (left)
        {
            movement.x = -1;
        }
        if (right)
        {
            movement.x = 1;
        }
        if (!left && !right)
        {
            movement.x = 0;
        }

        if (down)
        {
            movement.y = -1;
        }
        if (up)
        {
            movement.y = 1;
        }

        if (!down && !up)  
        {
            movement.y = 0;
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

    public void OnMoveLEFT(InputValue value)
    {
        left = value.isPressed;
    }

    public void OnMoveRIGHT(InputValue value)
    {
        right = value.isPressed;
    }

    public void OnMoveUP(InputValue value)
    {
        up = value.isPressed;
    }

    public void OnMoveDOWN(InputValue value)
    {
        down = value.isPressed;
    }

    public void MoveLeftInput(bool value)
    {
        left = value;
    }

    public void MoveRightInput(bool value)
    {
        right = value;
    }

    public void MoveUpInput(bool value)
    {
        up = value;
    }

    public void MoveDownInput(bool value)
    {
        down = value;
    }
}
