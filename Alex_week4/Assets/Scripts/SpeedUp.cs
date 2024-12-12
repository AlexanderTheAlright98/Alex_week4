using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            if (Input.GetKey(KeyCode.D))
            {
                Time.timeScale = 2;
            }

            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
