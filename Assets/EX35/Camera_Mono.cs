using JetBrains.Annotations;
using UnityEngine;

public class Camera_Mono : MonoBehaviour
{
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Camera.main.transform.position = new Vector3(0, 0, -10) + GameObject.Find("Player").transform.position;






    }
}

