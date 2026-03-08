using UnityEngine;

public class VirusSpawner : MonoBehaviour
{
    public GameObject virusPrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("SpawnVirus", 1f, spawnRate);
    }

    void SpawnVirus()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);

        Vector2 spawnPos = new Vector2(x, y);

        Instantiate(virusPrefab, spawnPos, Quaternion.identity);
    }
}