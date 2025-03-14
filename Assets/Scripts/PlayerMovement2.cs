using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement2 : MonoBehaviour
{
    //Movement
    public float speed;
    public float jump;
    float moveVelocity;
    private float inputX;

    //Grounded Vars
    bool grounded = true;
    bool jumping;

    //Jumping Vars
    public int maxJumps = 2;
    private int jumpCount;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = maxJumps;
    }

    void Update()
    {
        //Jumping
        if (jumping)
        {
            if (grounded || jumpCount > 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                jumpCount--;
                jumping = false;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (inputX < 0)
        {
            moveVelocity = -speed;
        }
        if (inputX > 0)
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }

    //Check if Grounded with tag check
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Check if colliding object has "Ground" tag
        {
            grounded = true;
            jumpCount = maxJumps;
        }
    }

    void OnCollisionExit2D()
    {
        grounded = false;
    }

    public void OnMove(InputValue value)
    {
        inputX = value.Get<Vector2>().x;
    }

    public void MoveInput (Vector2 value)
    {
        inputX = value.x;
    }

    public void JumpInput(bool value)
    {
        jumping = value;
    }

    public void OnJump(InputValue value)
    {
        jumping = value.isPressed;
    }
}
