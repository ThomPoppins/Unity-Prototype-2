using UnityEngine;

public class MoveCookieForward : MonoBehaviour
{
    // The default cookie speed
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
