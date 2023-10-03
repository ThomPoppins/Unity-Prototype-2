using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnTriggerEnter is called when this object first touches a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // If other GameObject is the player do not destroy
        if (CompareTag("Cookie") && other.CompareTag("Player"))
        {
            return;
        } else if (!other.CompareTag("Player"))
        {
            // Destroy this game object
            Destroy(gameObject);
            // Destroy the other game object
            Destroy(other.gameObject);
        } else
        {
            // Destroy the game object
            Destroy(gameObject);
        }
    }
}
