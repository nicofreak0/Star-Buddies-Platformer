using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioClip herbertCollisionSound; // Audio clip for Herbert collision

    private bool hasPlayedAudio = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Herbert") && !hasPlayedAudio)
        {
            AudioManager.Instance.PlayOneShot(herbertCollisionSound);
            hasPlayedAudio = true;
        }

        // Destroy the object after playing the audio (if applicable)
        // You might not always want to destroy the object.
        // Consider this based on your game logic:
        // Destroy(gameObject);
    }
}