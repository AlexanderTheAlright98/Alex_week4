using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float jumpForce = 5;
    public bool isGameOver = false;
    public ParticleSystem dirtParticle;
    public AudioClip jumpNoise1, jumpNoise2, deathNoise;

    AudioSource playerAudioSource;
    Animator playerAnim;
    Rigidbody rb;
    [SerializeField] bool isGrounded;
    [SerializeField] bool canDoubleJump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !isGameOver)
        {
            playerAnim.SetTrigger("Jump_trig");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            canDoubleJump = true;
            playerAudioSource.PlayOneShot(jumpNoise1);
            dirtParticle.Stop();
        }

        if (canDoubleJump)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                playerAnim.SetTrigger("Jump_trig");
                rb.linearVelocity = Vector3.up * 1.15f * jumpForce;
                canDoubleJump= false;
                playerAudioSource.PlayOneShot(jumpNoise2);
            }
        }

        if (isGameOver)
        {
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            playerAudioSource.PlayOneShot(deathNoise);
            Time.timeScale = 0.25f;
            dirtParticle.Stop();

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        dirtParticle.Play();

        if (collision.collider.tag == "Obstacles")
        {
            isGameOver = true;
        }
    }
}
