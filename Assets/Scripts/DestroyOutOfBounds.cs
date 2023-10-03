using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Top boundary
    private float topBound = 35.0f;
    // Bottom boundary
    private float lowerBound = -10.0f;
    // Left bound
    private float leftBound = -25.0f;
    // Right bound
    private float rightBound = 25.0f;

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
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        } else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        } else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
