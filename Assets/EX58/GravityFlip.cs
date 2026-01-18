using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    enum GravityDirection { Down, Left, Up, Right };
    GravityDirection  m_GravityDirection;
    private bool gravityChangeRequested = false;

    void Start()
    {
        m_GravityDirection = GravityDirection.Down;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityChangeRequested = true;
        }

    }

    void FixedUpdate()
    {
        Vector2 gravity = Vector2.zero;

        if (gravityChangeRequested)
        {
            m_GravityDirection = (GravityDirection)(((int)m_GravityDirection + 1) % 4);
            gravityChangeRequested = false;
        }
        switch (m_GravityDirection)
        {
            case GravityDirection.Down:
                gravity = new Vector2(0, -9.81f);
                break;
            case GravityDirection.Left:
                gravity = new Vector2(-9.81f, 0);
                break;
            case GravityDirection.Up:
                gravity = new Vector2(0, 9.81f);
                break;
            case GravityDirection.Right:
                gravity = new Vector2(9.81f, 0);
                break;
        }
        Physics2D.gravity = gravity;
    }
}
