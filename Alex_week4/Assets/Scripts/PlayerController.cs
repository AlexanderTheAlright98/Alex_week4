using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float jumpForce = 5;
    public Renderer rend;
    
    Rigidbody rb;
    [SerializeField] bool isGrounded;
    [SerializeField] bool isGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponentInChildren<SkinnedMeshRenderer>();
        rend.enabled = true;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (isGameOver)
        {
            Time.timeScale = 0;
            rend.enabled = false;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;

        if (collision.collider.tag == "Obstacles")
        {
            isGameOver = true;
        }
    }
}
