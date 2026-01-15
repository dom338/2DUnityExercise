using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    private float collisionCount = 0;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            collisionCount += 1;
            Debug.Log("Collision Count: " + collisionCount);
        }
    }
}

