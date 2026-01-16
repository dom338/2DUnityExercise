using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EX_56_Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float destroyrange = 3.0f;
    
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
            DestroyEnemy();
        }
    }

    void DestroyEnemy()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, destroyrange);
        List<GameObject> enemiesToDestroy = new List<GameObject>();
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Enemy"))
            {
                enemiesToDestroy.Add(hitCollider.gameObject);
            }
        }
        foreach (var enemy in enemiesToDestroy)
        {
            Destroy(enemy);
        }
    }






}
