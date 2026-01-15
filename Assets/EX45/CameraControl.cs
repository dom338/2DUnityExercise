using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Direction = new Vector3(0,0,0);
        if (Keyboard.current.dKey.isPressed)
        {
            Direction += new Vector3(1,0,0);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Direction += new Vector3(-1,0,0);
        }
        transform.position = transform.position + Direction * speed * Time.deltaTime;

    }
}
