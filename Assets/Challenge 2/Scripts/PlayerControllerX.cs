using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool validSpacebar = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog and then call function that will set valid spacebar to false and to true after 1 second
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (validSpacebar)
            {
                SendDog();
                StartCoroutine(SpacebarTimer());
            }
        }
    }

    // Function that will set a timer of 1 second before the spacebar can be pressed again
    IEnumerator SpacebarTimer()
    {
        validSpacebar = false;
        yield return new WaitForSeconds(1);
        validSpacebar = true;
    }

    // Send dog function
    void SendDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
