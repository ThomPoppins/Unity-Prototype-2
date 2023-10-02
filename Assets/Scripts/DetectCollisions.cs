using System.Collections;
using System.Collections.Generic;
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
        // Destroy the game object (cookie)
        Destroy(gameObject);
        // Destroy the other game object (dog)
        Destroy(other.gameObject);
    }
}
