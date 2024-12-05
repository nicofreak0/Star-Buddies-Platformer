using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public int points = 1;
    public ScoreScript scoreScript;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Herbert")
        {
            scoreScript.AddScore(points);
            Destroy(gameObject);
        }
    }
}