using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    //Movement
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool grounded = true;

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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded || jumpCount > 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                jumpCount--;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
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
}