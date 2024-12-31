using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget; // Assign the target Transform in the Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object has the desired tag (optional)
        if (other.gameObject.CompareTag("Herbert"))
        {
            // Teleport the player to the target position
            other.transform.position = teleportTarget.position;
        }
    }
}