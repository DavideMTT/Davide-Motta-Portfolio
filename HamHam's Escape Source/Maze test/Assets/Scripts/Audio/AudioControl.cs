using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioControl : MonoBehaviour
{
    
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource musicSource;
    public AudioClip inGame;
    public AudioClip mainMenu;


    //public AudioClip mainMenu;
    public AudioClip timeUp;
    public AudioClip death;
    public AudioClip checkpoint;
    public AudioClip speedBoost;
    public AudioClip walking;
    public AudioClip keyPickup;
    public AudioClip menuButtons;
    public AudioClip door;
    public AudioClip trap;
    public AudioClip catMeow;
    //public AudioClip inGame;


    private void Start()
    {
        //musicSource.clip = mainMenu;
        //musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public AudioSource mainGameMusic;
    public AudioSource pauseMusic;

    private bool isPaused = false;

    public void PauseAudio(AudioClip audio)
    {
        AudioSource currentAudio = gameObject.GetComponent<AudioSource>();
        currentAudio.clip = audio;
        Debug.Log(currentAudio.clip);
        currentAudio.Pause();
    }

    public void ResumeAudio(AudioClip audio)
    {
        AudioSource currentAudio = gameObject.GetComponent<AudioSource>();
        currentAudio.clip = audio;
        Debug.Log(currentAudio.clip);
        currentAudio.Play();
    }
}
