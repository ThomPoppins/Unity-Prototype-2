using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the user's horizontal input from the input manager
        horizontalInput = Input.GetAxis("Horizontal"); // This is a value between -1 and 1
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
