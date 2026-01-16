using UnityEngine;

public class FollowHorizontal : MonoBehaviour
{
    public GameObject target;
    public float speed = 5.0f;
    private float fixedY = 0.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, fixedY, target.transform.position.z);


    }
}
