using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public int points = 1;
    private ScoreScript scoreScript;

    public void Start()
    {
        scoreScript = GameObject.Find("ScoreManager").GetComponent<ScoreScript>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Herbert")
        {
            scoreScript.AddScore(points);
            Destroy(gameObject);
        }
    }
}