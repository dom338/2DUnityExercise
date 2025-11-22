using UnityEngine;
using UnityEngine.UIElements;

public class BasicMouvmentSpeed : MonoBehaviour
{
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-1, -1, 0) * speed;
    }
}
