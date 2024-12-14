using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x;
    }

    void Update()
    {
        if (transform.position.x < startPos.x - (repeatWidth / 2))
        {
            transform.position = startPos;
        }


    }
}


