using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Change to get more functionality - right now this just clears the created object after a few seconds so that spawning multiple types can be tested
        Invoke("RemoveObject", 3);
    }
    void RemoveObject()
    {
        Destroy(this.gameObject);
    }
}
