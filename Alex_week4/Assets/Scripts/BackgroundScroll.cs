using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField] float scrollSpeed;
    float backgroundWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        backgroundWidth = GetComponent<BoxCollider>().size.x;
        //This fetches the x scale of the Background's box collider
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < startPos.x - (backgroundWidth / 2))
        {
            transform.position = startPos;
        }
        //This makes the background scroll seamlessly. It also works because of how the texture is designed
    }
}
