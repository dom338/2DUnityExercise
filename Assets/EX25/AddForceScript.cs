using UnityEngine;

public class AddForceScript : MonoBehaviour
{
    public Rigidbody2D MyRB;
    public Vector2 ForceAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyRB.AddForce(ForceAmount, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
