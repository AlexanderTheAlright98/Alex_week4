using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteRabbit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene("Level 1");
            Destroy(gameObject);
        }
    }
}
