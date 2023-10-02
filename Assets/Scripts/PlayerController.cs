using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The user's horizontal input
    public float horizontalInput;
    // The default player speed
    public float speed = 10.0f;
    // The maximum distance the player can move left or right
    public float xRange = 20.0f;
    // The cookie prefab
    public GameObject cookiePrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Avoid the player moving off the screen
        if (transform.position.x < -xRange)
        {
            // If the player moves too far left, set the position to the left edge of the screen
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            // If the player moves too far right, set the position to the right edge of the screen
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



        // Get the user's horizontal input from the input manager
        horizontalInput = Input.GetAxis("Horizontal"); // This is a value between -1 and 1
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // If the user presses the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a cookie from the player
            Instantiate(cookiePrefab, transform.position, cookiePrefab.transform.rotation);
        }
    }
}
