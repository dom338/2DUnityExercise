using UnityEngine;
using UnityEngine.InputSystem;

public class Player64 : MonoBehaviour
{
    public float speed = 5.0f;
    public AudioClip SpawnSound;
    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = SpawnSound;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }

    }

    void SpawnObject()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = transform.position + new Vector3(0, 0, 0);
        audioSource.Play();


    }
}
