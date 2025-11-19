using UnityEngine;

public class MultiplyTable : MonoBehaviour
{
    public float number = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Multiplication Table for " + number);
        for (int i = 1; i <= 10; i++)
        {
            float result = number * i;
            Debug.Log(number + " x " + i + " = " + result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
