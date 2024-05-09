using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{

   // PlayerHealth referenceToPlayerHealth;
    //int currentPlayerHealth;

    // Play botton function

    private void Awake()
    {
       //referenceToPlayerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();   
    }

    private void Update()
    {
        //currentPlayerHealth = referenceToPlayerHealth.CheckCurrentHealth();
    }
    public void PlayGameButton()
    {
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Time.timeScale = 1.0f;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, 0);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        
       //if (referenceToPlayerHealth.CheckCurrentHealth) { 
        
       //}
    }

    public void SwitchToIns()
    {
        SceneManager.LoadScene("Instructions");
        Time.timeScale = 1.0f;
    }
}
