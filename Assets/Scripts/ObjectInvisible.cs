using System.Collections;
using UnityEngine;

public class RandomAppearance : MonoBehaviour
{
    public float minInterval = 1.0f; // Minimum time before the object reappears
    public float maxInterval = 5.0f; // Maximum time before the object reappears

    private Renderer objectRenderer;
    private bool isVisible = true;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("Renderer component not found on this GameObject.");
            return;
        }
        // Start the coroutine to handle the random appearance logic
        StartCoroutine(RandomAppearanceCoroutine());
    }

    private IEnumerator RandomAppearanceCoroutine()
    {
        while (true)
        {
            // Generate a random interval
            float randomInterval = Random.Range(minInterval, maxInterval);

            // Toggle visibility
            ToggleVisibility(false);

            // Wait for the random interval
            yield return new WaitForSeconds(randomInterval);

            // Toggle visibility
            ToggleVisibility(true);

            // Wait for the random interval before hiding again
            yield return new WaitForSeconds(randomInterval);
        }
    }

    private void ToggleVisibility(bool visible)
    {
        isVisible = visible;
        objectRenderer.enabled = visible;
    }
}