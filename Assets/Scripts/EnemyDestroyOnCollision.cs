using UnityEngine;

public class EnemyDestroyOnCollision : MonoBehaviour
{
    // The name of the tag for Herbert
    public string herbertTag = "Herbert";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(herbertTag))
        {
            Destroy(gameObject);
        }
    }
}