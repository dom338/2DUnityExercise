using UnityEngine;

public class SpaceToJump : MonoBehaviour
{
    public Rigidbody2D MyRB;
    public float JumpAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRB.AddForce(new Vector2(0, JumpAmount), (ForceMode2D)ForceMode.Impulse);
        }
    }
}
