using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // The dog prefabs
    public GameObject[] dogPrefabs;
    // The range to spawn the dogs
    private float spawnRangeX = 20;
    // The spawn position
    private float spawnPosZ = 30;
    // The spawn delay
    private float startDelay = 2;
    // The spawn interval
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Repeatedly spawn a random dog
        InvokeRepeating("SpawnRandomDog", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomDog()
    {
        // Random dog index for spawning a random dog
        int dogIndex;
        dogIndex = Random.Range(0, dogPrefabs.Length);

        // Random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX + 1), 0, spawnPosZ);

        // Spawn a dog
        Instantiate(dogPrefabs[dogIndex], spawnPos, dogPrefabs[dogIndex].transform.rotation);
    }
}
