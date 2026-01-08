using System;
using UnityEngine;

public class DestorySelfOnCollision : MonoBehaviour
{
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
