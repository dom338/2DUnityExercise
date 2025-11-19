using UnityEngine;

public class RandomOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = Random.Range(-10, 10);
        int b = Random.Range(-10, 10);
        int operation = Random.Range(0, 5);

        if (operation == 0)
        {
            Debug.Log(a + b);
        }
        else if (operation == 1)
        {
            Debug.Log(a - b);
        }
        else if (operation == 2)
        {
            Debug.Log(a * b);
        }
        else if (operation == 3)
        {
            if (b != 0)
            {
                Debug.Log(a / b);
            }
            else
            {
                Debug.Log("Division by zero is not allowed.");
            }
        }
        else if (operation == 4)
        {
            Debug.Log(a % b);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
