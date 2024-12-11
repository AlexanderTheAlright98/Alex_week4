using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    public GameObject rabbitPrefab;
    public float startDelay = 1.75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float spawnInterval = Random.Range(1.95f, 3.25f);
        InvokeRepeating("ObstacleSpawning", startDelay, spawnInterval);
        float rabbitSpawnInterval = Random.Range(4, 10);
        InvokeRepeating("RabbitSpawning", startDelay * 3, rabbitSpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ObstacleSpawning()
    {
        int randomIndex = Random.Range(0, obstaclePrefabs.Length);

        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            Vector3 randomSpawn = new Vector3(Random.Range(19, 30), 0, 0);
            Instantiate(obstaclePrefabs[randomIndex], randomSpawn, Quaternion.identity);
        }
    }
    void RabbitSpawning()
    {
        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            Vector3 randomSpawn2 = new Vector3(Random.Range(19, 30), 6.1f, 0);
            Instantiate(rabbitPrefab, randomSpawn2, Quaternion.Euler(0, 90, 0));
        }
    }
}
