using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {

       
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(level);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
