using UnityEngine;

public class CounterButton : MonoBehaviour
{
    public int counter = 0; 
    public TMPro.TextMeshProUGUI counterText;
    public void OnButtonClick()
    {
        counter++;
        counterText.text = "Button clicked " + counter + " times!";
        Debug.Log("Button clicked " + counter + " times!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
