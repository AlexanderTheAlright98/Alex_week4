using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float obstacleSpeed = 10;
    public float xRange = -9;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);

        if (transform.position.x <= xRange)
        {
            Destroy(gameObject);
        }
    }
}
