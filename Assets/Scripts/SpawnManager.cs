using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // The dog prefabs
    public GameObject[] dogPrefabs;
    // The range to spawn the dogs
    public float spawnRangeX = 15;
    // The side the dog will spawn from
    public string[] spawnOrigin = { "left", "right", "top" };
    // The spawn position on the Z axis
    private float spawnPosZ = 30;
    // The left spawn position on the X axis
    private float leftSpawnPosX = -25;
    // Lower spawn range on the Z axis when dog spawns from the left
    private float leftSpawnLowerRangeZ = 0;
    // Upper spawn range on the Z axis when dog spawns from the left
    private float leftSpawnUpperRangeZ = 15;
    // The right spawn position on the X axis
    private float rightSpawnPosX = 15;
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

        // Random origin for spawning a dog
        string origin = spawnOrigin[Random.Range(0, spawnOrigin.Length)];

        // Spawn a dog from the top, left, or right
        if (origin == "top")
        {
            // Spawn a dog from the top:
            // Random spawn position from the Z axis
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX + 1), 0, spawnPosZ);

            // Spawn a dog
            Instantiate(dogPrefabs[dogIndex], spawnPos, dogPrefabs[dogIndex].transform.rotation);
        }
        else if (origin == "left")
        {
            // Spawn a dog from the left:
            // Random spawn position from the left on the X axis
            Vector3 spawnPos = new Vector3(leftSpawnPosX, 0, Random.Range(leftSpawnLowerRangeZ, leftSpawnUpperRangeZ + 1));

            // Quaternion rotation for the dog
            Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

            // Spawn a dog from the left
            Instantiate(dogPrefabs[dogIndex], spawnPos, spawnRotation);
        }
        else if (origin == "right")
        {
            // Spawn a dog from the right:
            // Random spawn position from right on the X axis
            Vector3 spawnPos = new Vector3(rightSpawnPosX, 0, Random.Range(leftSpawnLowerRangeZ, leftSpawnUpperRangeZ + 1));

            // Quaternion rotation for the dog
            Quaternion spawnRotation = Quaternion.Euler(0, -90, 0);

            // Spawn a dog from the right
            Instantiate(dogPrefabs[dogIndex], spawnPos, spawnRotation);
        }
    }
}
