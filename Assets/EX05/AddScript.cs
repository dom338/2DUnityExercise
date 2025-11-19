using UnityEngine;

public class AddScript : MonoBehaviour
{
    public int a = 5;
    public int b = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
