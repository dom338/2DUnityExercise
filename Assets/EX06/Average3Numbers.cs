using UnityEngine;

public class Average3Numbers : MonoBehaviour
{
    public int num1 = 5;
    public int num2 = 10;
    public int num3 = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((num1 + num2 + num3) / 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
