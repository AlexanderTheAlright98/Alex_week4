using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteRabbit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            int sceneIndex = Random.Range(1, 7);
            SceneManager.LoadScene(sceneIndex);
            Destroy(gameObject);
        }
    }
}
