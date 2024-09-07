using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public Transform[] spawnPositions;

    public GameObject car;
    float nextTimeToSpawn = 0.0f;

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPositions.Length);
        Transform spawnPosition = spawnPositions[randomIndex];

        Instantiate(car, spawnPosition.position, spawnPosition.rotation);
    }

    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }
}
