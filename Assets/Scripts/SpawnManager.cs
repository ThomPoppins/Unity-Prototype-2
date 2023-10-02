using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the s key is pressed, spawn a dog with index `docIndex` from the `dogPrefabs` array and place it at the spawn position 0, 0, 30 with it's default rotation
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Random dog index for spawning a random dog
            int dogIndex;
            dogIndex = Random.Range(0, dogPrefabs.Length);

            // Random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-15, 16), 0, 30);

            // Spawn a dog
            Instantiate(dogPrefabs[dogIndex], spawnPos, dogPrefabs[dogIndex].transform.rotation);
        }
    }
}
