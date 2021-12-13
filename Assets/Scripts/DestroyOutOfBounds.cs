using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Declare variable
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check whether object is at lowerbound
       if(transform.position.z < lowerBound)
        {
            // Destroy objects
            Destroy(gameObject);
        } 
    }
}
