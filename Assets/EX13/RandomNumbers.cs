using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (count < 100)
        {
            int randomNumber = Random.Range(1, 101); // Generates a random number between 1 and 100
            Debug.Log("Random Number: " + randomNumber);
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
