using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System;

public class Player61 : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject objectToSpawn;
    private int spawnCount = 0;
    public TMPro.TMP_Text spawnCountText;
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

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SpawnObject();
        }

    }

    void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn);
        newObject.transform.position = transform.position + new Vector3(0, 0, 0);
        spawnCount++;
        spawnCountText.text = spawnCount.ToString();

        Destroy(newObject, 3.0f);
        Invoke("Despawn", 3.0f);
    }

    
    void Despawn()
    {
        spawnCount--;
        spawnCountText.text = spawnCount.ToString();
    }
}
