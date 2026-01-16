using UnityEngine;

public class FollowWhenNear : MonoBehaviour
{
    public GameObject player;
    public float followDistance = 5.0f;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer < followDistance)
        {
            Vector3 directionToPlayer = (player.transform.position - transform.position).normalized;
            transform.position = transform.position + directionToPlayer * speed * Time.deltaTime;
        }

    }
}
