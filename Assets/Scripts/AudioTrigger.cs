using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField]
    public AudioSource audio;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Herbert"))
            audio.Play();
    }
}