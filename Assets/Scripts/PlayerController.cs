using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The user's horizontal input
    public float horizontalInput;
    // The user's vertical input
    public float verticalInput;
    // The default player speed
    public float speed = 10.0f;
    // The maximum distance the player can move left or right
    public float xRange = 20.0f;
    // Bottom boundary
    public float zLowerBound = 0;
    // Top boundary
    public float zUpperBound = 15;
    // The cookie prefab
    public GameObject cookiePrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Avoid the player moving off the screen horizontally
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

        // Avoid the player moving off the screen vertically
        if (transform.position.z < zLowerBound)
        {
            // If the player moves too far down, set the position to the bottom edge of the screen
            transform.position = new Vector3(transform.position.x, transform.position.y, zLowerBound);
        }
        else if (transform.position.z > zUpperBound)
        {
            // If the player moves too far up, set the position to the top edge of the screen
            transform.position = new Vector3(transform.position.x, transform.position.y, zUpperBound);
        }

        // Get the user's horizontal input from the input manager
        horizontalInput = Input.GetAxis("Horizontal"); // This is a value between -1 and 1
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Get the user's vertical input from the input manager
        verticalInput = Input.GetAxis("Vertical"); // This is a value between -1 and 1
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        // If the user presses the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a cookie from the player
            Instantiate(cookiePrefab, transform.position, cookiePrefab.transform.rotation);
        }
    }
}
