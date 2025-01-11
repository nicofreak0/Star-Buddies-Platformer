using UnityEngine;

public class PenaltyObject : MonoBehaviour
{
    public int penaltyPoints = 2;
    public ScoreScript scoreScript;

    private void Start()
    {
        scoreScript = GameObject.Find("ScoreManager").GetComponent<ScoreScript>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Herbert"))
        {
            scoreScript.DeductPoints(penaltyPoints);
            Destroy(gameObject);

        }
    }



}