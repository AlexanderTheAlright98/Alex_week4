using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float score = 0;
    public TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString("N0");

        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            score += Time.deltaTime;
        }
    }
}
