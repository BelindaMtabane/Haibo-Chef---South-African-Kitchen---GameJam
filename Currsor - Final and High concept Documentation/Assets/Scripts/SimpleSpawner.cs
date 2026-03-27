using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int maxCount = 10;
    [SerializeField] private float minX = 233.72f;
    [SerializeField] private float maxX = 253.94f;
    [SerializeField] private float spawnY = 50.2f;
    [SerializeField] private float maxZ = 47.9f;
    [SerializeField] private float minZ = -50.36f;
    [SerializeField] private float interval = 0.5f;

    private float timer;
    private int spawned;

    private void Update()
    {
        if (prefab == null || spawned >= maxCount) return;

        timer += Time.deltaTime;
        if (timer < interval) return;

        timer = 0f;
        float x = Random.Range(minX, maxX);
        float z = Random.Range(minZ, maxZ);
        Vector3 spawnPos = new Vector3(x, spawnY, z);
        Instantiate(prefab, spawnPos, Quaternion.identity);
        spawned++;
    }
}
