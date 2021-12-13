using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Declare Variables
    private GameManager gameManager;
    private PlayerController playerController;
    public ParticleSystem explosionParticle;

    public int pointVal;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the GameManager object
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method that detects collision
    void OnTriggerEnter(Collider other)
    {
        // Instantiate the particle for explosion
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        //gameManager.playerAudio.PlayOneShot(crashSound, 1.0f);
        // Update Game score 
        gameManager.UpdateScore(pointVal);
        // Destroy objects after collision
        Destroy(gameObject);
    }
}
