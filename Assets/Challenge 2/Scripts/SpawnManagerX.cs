using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -30.0f;
    private float spawnLimitXRight = 6.5f; 
    private float spawnPosY = 25.0f;

    private float startDelay = 1.0f;
    private float randomSpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        randomSpawnInterval = Random.Range(3.0f , 5.0f);
        InvokeRepeating("SpawnRandomBall", startDelay, randomSpawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
