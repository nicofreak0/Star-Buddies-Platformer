using UnityEngine;

public class VerticalOscillator : MonoBehaviour
{
    public float speed = 2.0f; // Speed of the movement
    public float distance = 1.0f; // Maximum distance from the starting position

    private Vector3 startPosition;
    private float elapsedTime = 0.0f;

    void Start()
    {
        // Store the initial position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        // Update elapsed time
        elapsedTime += Time.deltaTime * speed;

        // Calculate the new y position using a sine wave
        float newY = startPosition.y + Mathf.Sin(elapsedTime) * distance;

        // Apply the new position to the object
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}