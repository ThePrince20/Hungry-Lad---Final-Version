using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour
{
    // PlayButton method
   public void PlayButton()
    {
        // Loads GameScene
        SceneManager.LoadScene("Game Scene");
    }
}
