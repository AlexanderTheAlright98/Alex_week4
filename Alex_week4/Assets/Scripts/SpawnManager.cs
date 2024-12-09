using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    public float startDelay = 1.75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float spawnInterval = Random.Range(1.75f, 3.25f);
        InvokeRepeating("ObstacleSpawning", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ObstacleSpawning()
    {
        int randomIndex = Random.Range(0, obstaclePrefabs.Length);

        Vector3 randomSpawn = new Vector3(Random.Range(19, 30), 0, 0);
        Instantiate(obstaclePrefabs[randomIndex], randomSpawn, Quaternion.identity);
    }
}
