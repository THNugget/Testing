using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] enemyPrefabs;
    public bool canSpawn = true;
    public float spawnRate = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate -= Time.deltaTime;
        if(spawnRate <= 0f)
        {
            canSpawn = true;
        }
        if (canSpawn)
        {
            canSpawn = false;
            spawnRate = 3f;
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(enemyPrefabs[0], spawnPoint[randSpawnPoint].position, transform.rotation);
        }
    }
}
