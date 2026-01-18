using UnityEngine;
using UnityEngine.InputSystem;

public class Player63 : MonoBehaviour
{
    public float speed = 5.0f;
    public AudioClip collectSound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = collectSound;
        audioSource.playOnAwake = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            direction += new Vector3(0, 1, 0);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction += new Vector3(0, -1, 0);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direction += new Vector3(-1, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction += new Vector3(1, 0, 0);
        }
        transform.position = transform.position + direction * speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            audioSource.Play();
            Destroy(collision.gameObject);
        }
    }
}
