using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Declare variables
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timerText;
    public Button RestartButton;

   private SpawnManager spawnManager;

    private int score;

    public bool isGameActive;
    public float timeLeft;

    //public AudioSource playerAudio;

    //public AudioClip crashSound;
    //public AudioClip missSound;

    // Start is called before the first frame update
    void Start()
    {
        //playerAudio = GetComponent<AudioSource>();

        // Initialise score to 0
        score = 0;
        // Set Game Active
        isGameActive = true;
        // Gets the SpawnManager Script
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Checks whether Game is Active
        if (isGameActive)
        {
            // Reduces time
            timeLeft -= Time.deltaTime;
            // Prints time
            timerText.SetText("Time Left: " + Mathf.Round(timeLeft));
            // Check to see whether time is less than 0
            if (timeLeft < 0)
            {
                // Calls GameOver method
                GameOver();
            }
        }

        // Check whether score is less than 0
        if (score < 0)
        {
            // Call GameOver method
            GameOver();
        }
    }

    // Restart Game Method
    public void RestartGame()
    {
        // Reloads the game scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Game over method
    public void GameOver()
    {
        // Brings GameOver Button and Restart Button on screen
        gameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
        // Makes Game Inactive
        isGameActive = false;
        // Stops object spawnings
        spawnManager.CancelInvoke();
    }

    // Update Score Method
    public void UpdateScore(int scoreToAdd)
    {
        // Adds scoreToAdd to score
        score += scoreToAdd;
        // Prints Score
        scoreText.text = "Score: " + score;
    }
}
