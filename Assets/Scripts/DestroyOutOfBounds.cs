using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Top boundary
    private float topBound = 35.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy GameObject when it goes out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
