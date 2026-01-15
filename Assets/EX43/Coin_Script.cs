using UnityEngine;

public class Coin_Script : MonoBehaviour
{
    private float caunter = 0.0f;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Destroy(this.gameObject);
            caunter += 1.0f;
            Debug.Log("Coins collected: " + caunter);
        }
    }
}
