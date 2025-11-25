using UnityEngine;

public class SpawnRandomObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y),
            Random.Range(spawnAreaMin.z, spawnAreaMax.z)
        );
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
