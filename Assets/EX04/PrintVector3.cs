using UnityEngine;

public class PrintVector3 : MonoBehaviour
{
    public Vector3 myVector = new Vector3(1.0f, 2.0f, 3.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(myVector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
