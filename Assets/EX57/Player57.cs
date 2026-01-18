using UnityEngine;
using UnityEngine.InputSystem;


public class Player57 : MonoBehaviour
{
    public float speed = 5.0f;
    public float explosionRange = 3.0f;
    public float explosionForce = 120.0f;

    private Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
            Explode();
        }
    }

    void Explode()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, explosionRange);

        for (int i = 0; i < hitColliders.Length; i++)
        {
            Rigidbody2D hitRb = hitColliders[i].attachedRigidbody;
            if (hitRb == rb)
            {
                continue;
            }
            if (hitRb != null)
            {
                Vector2 direction = hitRb.position - new Vector2(transform.position.x, transform.position.y);
                direction.Normalize();
                hitRb.AddForce(direction * explosionForce);
            }
           
        }



    }
}
