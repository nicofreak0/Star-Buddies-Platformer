using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] starPrefabs;

    private float spawnLimitXLeft = -8.64f;
    private float spawnLimitXRight = 8.64f;
    private float spawnPosY = 14.06f;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("SpawnRandomStar", startDelay);
    }

    // Spawn random star at random x position at top of play area
    void SpawnRandomStar()
    {
        // Generate random star index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //instantiate random star from array
        int starIndex = Random.Range(0, starPrefabs.Length);

        Instantiate(starPrefabs[starIndex], spawnPos, starPrefabs[starIndex].transform.rotation);

        //randomize spawn interval
        spawnInterval = Random.Range(0.5f, 3.0f);

        //invoke again
        Invoke("SpawnRandomStar", spawnInterval);
        Debug.Log("spawnInterval:" + spawnInterval);
    }

}
