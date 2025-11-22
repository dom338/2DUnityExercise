using UnityEngine;
using UnityEngine.InputSystem;

public class MouvmentWithTranslate : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouvmentUP = new Vector3(0,1,0);
        Vector3 mouvmentDown = new Vector3(0,-1,0);
        Vector3 mouvmentLeft = new Vector3(-1,0,0);
        Vector3 mouvmentRight = new Vector3(1,0,0);

        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(mouvmentUP * speed * Time.deltaTime);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(mouvmentDown * speed * Time.deltaTime);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(mouvmentLeft * speed * Time.deltaTime);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(mouvmentRight * speed * Time.deltaTime);
        }


    }
}
