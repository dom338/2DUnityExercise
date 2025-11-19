using UnityEngine;

public class CalculatorScript : MonoBehaviour
{
    public float number1 = 12.5f;
    public float number2 = 3.5f;
    public string operation = "+";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (operation == "+")
        {
            Debug.Log(number1 + number2);
        }
        else if (operation == "-")
        {
            Debug.Log(number1 - number2);
        }
        else if (operation == "*")
        {
            Debug.Log(number1 * number2);
        }
        else if (operation == "/")
        {
            if (number2 != 0)
            {
                Debug.Log(number1 / number2);
            }
            else
            {
                Debug.Log("Error: Division by zero");
            }
        }
        else if (operation == "%")
        {
            Debug.Log(number1 % number2);
        }
        else
        {
            Debug.Log("Error: Invalid operation");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
