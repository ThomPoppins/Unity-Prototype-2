using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogPrefabs;
    public int dogIndex;
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
            Instantiate(dogPrefabs[dogIndex], new Vector3(0, 0, 30), dogPrefabs[dogIndex].transform.rotation);
        }
    }
}
