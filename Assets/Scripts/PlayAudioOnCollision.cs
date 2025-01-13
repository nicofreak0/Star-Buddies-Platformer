using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioSource audioSource;

    private bool hasPlayedAudio = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Herbert") && !hasPlayedAudio)
        {
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
                hasPlayedAudio = true;
            }
            else
            {
                Debug.LogError("AudioSource or AudioClip is missing on " + gameObject.name);
            }
        }

        // Destroy the object after playing the audio (if applicable)
        // You might not always want to destroy the object. 
        // Consider this based on your game logic:
        // Destroy(gameObject); 
    }
}