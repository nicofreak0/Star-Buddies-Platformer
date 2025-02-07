using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroll : MonoBehaviour
{

    public float moveSpeed = 100f;
    private bool hasWaited;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Waited", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasWaited)
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    void Waited()
    {
        hasWaited = true;

    }
}
