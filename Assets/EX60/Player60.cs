using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player60 : MonoBehaviour
{
    public float speed = 5.0f;
    private GameObject objectToSpawn;
    private int spawnCount = 0;
    public TMP_Text spawnCountText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            direction += new Vector3(0, 1, 0);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction += new Vector3(0, -1, 0);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direction += new Vector3(-1, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction += new Vector3(1, 0, 0);
        }
        transform.position = transform.position + direction * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (objectToSpawn == null)
        {
            objectToSpawn = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objectToSpawn.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        GameObject newObject = Instantiate(objectToSpawn);
        newObject.transform.position = transform.position + new Vector3(0, 0, 0);
        spawnCount++;
        spawnCountText.text = spawnCount.ToString();

    }
}

