using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Create variables
    public GameObject prefab;
    public int maxCount = 2;
    public float minX = 233.72f;
    public float maxX = 253.94f;
    public float spawnY = 50.2f;
    public float maxZ = 47.9f;
    public float minZ = -50.36f;
    private int spawned;

    void Start()
    {
        for (int i = 0; i < maxCount; i++)
        {
            //Spawn in random x and z positions
            float x = Random.Range(minX, maxX);
            float z = Random.Range(minZ, maxZ);
            Vector3 spawnPos = new Vector3(x, spawnY, z);
            Instantiate(prefab, spawnPos, Quaternion.identity);
            spawned++;
        }
    }
}
