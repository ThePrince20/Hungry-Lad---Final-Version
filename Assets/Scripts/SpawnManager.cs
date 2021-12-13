using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Declare variables
    public GameObject[] objectsPrefab;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Keep Spawning objects
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObject()
    {
       // Create a new Vector3 object
       Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
       // Get the length of objects
       int index = Random.Range(0, objectsPrefab.Length);
       // Instantiate objects
       Instantiate(objectsPrefab[index], spawnPos, objectsPrefab[index].transform.rotation);
    }
}
