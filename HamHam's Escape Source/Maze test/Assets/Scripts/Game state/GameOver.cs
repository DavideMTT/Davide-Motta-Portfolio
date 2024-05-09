using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public PlayerHealth playerHealth; // Reference to the PlayerHealth script

    void Update()
    {
        // Check if the player's current health reaches 0
        if (playerHealth.currentHealth <= 0)
        {
            // If health is 0, load the game over scene
            SceneManager.LoadScene("GameOver");
        }

    }

    public void SwitchToMainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void SwitchToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
