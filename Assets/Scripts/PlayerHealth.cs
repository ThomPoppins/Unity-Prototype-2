using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Player lives
    public int lives = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives: " + lives);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // Prevent player to be destroyed by other objects
        if (other.CompareTag("Dog"))
        {
            // Destroy the other game object (dog)
            Destroy(other.gameObject);
            // Lose a life
            LoseLife(gameObject);
        }
    }

    void LoseLife(GameObject gameObject)
    {
        lives -= 1;

        Debug.Log("Lives: " + lives);

        if (lives == 0)
        {
            // Game over
            Debug.Log("Game Over!");

            // Destroy the player
            Destroy(gameObject);
        }
    }
}
