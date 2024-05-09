using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // this is when nothing happens aka player alive
        }
        else
        {
            Destroy(gameObject);// this is when the currenthealth of player is = 0 which is initiated from the playerHeath script resulting in the player dying
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver"); // in playerHealth we call this so it displays the GameOver scene
    }
}

