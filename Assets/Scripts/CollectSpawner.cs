using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSpawner : MonoBehaviour {
    float timeInBetweenSpawns = 1000f;
    float nextTimeToSpawn = 0f;

    public GameObject collect;
    public Transform[] spawnArea;

    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCollectible();
            nextTimeToSpawn = Time.time + timeInBetweenSpawns;
        }
    }

    void SpawnCollectible()
    {
        int randIndex = Random.Range(0, spawnArea.Length);
        Transform spawnPoint = spawnArea[randIndex];

        Instantiate(collect, spawnPoint.position, spawnPoint.rotation);
    }
}
