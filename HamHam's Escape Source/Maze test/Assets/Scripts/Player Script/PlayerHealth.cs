using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public int healthAmount;
    [SerializeField] GameObject player;
    public PlayerController thePlayer;

    AudioControl audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    public void TakeDamage(int amount, Vector3 direction)
    {
        audioManager.PlaySFX(audioManager.death);
        currentHealth -= amount;
        
        if (currentHealth <= 0)
        {
            
            currentHealth = 0; // ( for viktoria )Set health to 0 instead of destroying the player object directly, basically GameManager is where you actually kill the player
            GameManager.Instance.GameOver(); // Notify GameManager about game over so that it can kill the player and switch scene
        }

    }

    /*public void Healing(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (CompareTag("Player"))
        {

        }
    }*/

    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;

        // Optionally, you can clamp the health to the maximum health value
       //currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

}
