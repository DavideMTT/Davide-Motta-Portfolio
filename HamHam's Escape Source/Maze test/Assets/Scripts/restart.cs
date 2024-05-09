using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    
    public void SwitchToLevel01()
    {
        
        SceneManager.LoadScene("Level_01");
        Time.timeScale = 1f;
    }
}
