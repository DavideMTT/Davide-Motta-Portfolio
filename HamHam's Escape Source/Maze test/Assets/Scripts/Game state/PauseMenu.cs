using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    public bool mainMenu;
    GameUI gameUI;

    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ResumeGame(mainMenu);
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (isPaused)
            {
                mainMenu = false;
                ResumeGame(mainMenu);
                
            }
            else
            {
                mainMenu = true;
                PauseGame(mainMenu);
            }
            Debug.Log(mainMenu);
        }
    }


    public void PauseGame(bool state)
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        // Pause specific audio sources based on conditions
        if (state)
        {
            audioManager.PauseAudio(audioManager.inGame);
            audioManager.ResumeAudio(audioManager.mainMenu);
            
        }
       
    }

    public void ResumeGame(bool state)
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        // Resume specific audio sources based on conditions
        if (!state)
        {
            audioManager.PauseAudio(audioManager.mainMenu);
            audioManager.ResumeAudio(audioManager.inGame);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SwitchToMainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void SwitchToIns()
    {
        SceneManager.LoadScene("Instructions");
        
    }
    public void SwitchTo01()
    {
        SceneManager.LoadScene("Level_01");

    }


   
}
