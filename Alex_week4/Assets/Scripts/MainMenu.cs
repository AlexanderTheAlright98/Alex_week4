using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   void Update()
    {
        if (Input.anyKeyDown)
        {
            int sceneIndex = Random.Range(1, 7);
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
