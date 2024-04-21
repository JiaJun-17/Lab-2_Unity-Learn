using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float bufferTime = 2.5f;
    bool canSpawn = true;
    float spawnCooldown = 1.5f; // Adjust this value to set the cooldown time
    float nextSpawnTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //do not allow the user to spam the Space key
        if (canSpawn && Input.GetKeyDown(KeyCode.Space) && Time.time >= nextSpawnTime)
        {
            SpawnDog();
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }
    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

}
