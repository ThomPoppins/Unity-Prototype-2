using UnityEngine;

public class MoveAnimalsForward : MonoBehaviour
{
    // The default cookie speed
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the animals (dogs) forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
