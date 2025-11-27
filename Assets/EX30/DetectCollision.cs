using System.Runtime.CompilerServices;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
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
        Debug.Log("Collision Detected with " + collision.gameObject.name);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision Ended with " + collision.gameObject.name);
    }
}


