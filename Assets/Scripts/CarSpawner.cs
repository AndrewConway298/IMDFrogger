using UnityEngine;

public class CarSpawner : MonoBehaviour {

    float timeInBetweenSpawns = .5f;
    float nextTimeToSpawn = 0f;

    public GameObject car;
    public Transform[] spawnArea; 

    void Update()
    {
        if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + timeInBetweenSpawns;
        }
    }

    void SpawnCar()
    {
        int randIndex = Random.Range(0, spawnArea.Length);
        Transform spawnPoint = spawnArea[randIndex];
    
        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
