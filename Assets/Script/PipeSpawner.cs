using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 1f;
    public float pipeSpeed = 2f;

    public float minY = -1f;
    public float maxY = 2f;

    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer > spawnInterval)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(1.5f, randomY, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity); // Instantiate()
    }
}
