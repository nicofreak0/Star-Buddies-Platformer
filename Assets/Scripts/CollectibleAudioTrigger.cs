using UnityEngine;

public class CollectibleSound : MonoBehaviour
{
    public AudioClip collectSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Herbert")) // Adjust tag as needed
        {
            if (collectSound != null)
            {
                AudioManager.Instance.PlayOneShot(collectSound);
            }
            else
            {
                Debug.LogError("CollectibleSound: Missing collectSound AudioClip.");
            }
        }
    }
}