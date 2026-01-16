using JetBrains.Annotations;
using UnityEngine;

public class TriangleFollower : MonoBehaviour
{
    public GameObject Target;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            transform.position = MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
        }


    }

    public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
    {
        Vector3 toVector = target - current;
        float dist = toVector.magnitude;
        if (dist <= maxDistanceDelta || dist == 0f)
        {
            return target;
        }
        return current + toVector / dist * maxDistanceDelta;
    }
}
