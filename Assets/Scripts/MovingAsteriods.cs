using UnityEngine;

public class VerticalOscillator : MonoBehaviour
{
    public float speed = 2.0f; // Speed of the movement
    public float distance = 1.0f; // Maximum distance from the starting position
    public PauseMenu pauseMenu;
    private Vector3 startPosition;
    private float elapsedTime = 0.0f;

    void Start()
    {
        // Store the initial position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        

        if(pauseMenu.isPaused == false)
        {
            // Update elapsed time
            elapsedTime += Time.deltaTime * speed;

            // Calculate the new y position using a sine wave
            float newY = transform.position.y + Mathf.Sin(elapsedTime) * distance;

            if(newY >= 3)
            {
                newY = 3;
            }

            if(newY <= -3)
            {
                newY = -3;
            }
            // Apply the new position to the object
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}