using UnityEngine;

public class GravityTrigger : MonoBehaviour
{
    // Adjust the player's gravity scale
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Herbert"))
        {
            Rigidbody2D playerRigidbody = other.GetComponent<Rigidbody2D>();
            if (playerRigidbody != null)
            {
                playerRigidbody.gravityScale *= 1.50f; // almost doubles the gravity
            }
        }
    }
}