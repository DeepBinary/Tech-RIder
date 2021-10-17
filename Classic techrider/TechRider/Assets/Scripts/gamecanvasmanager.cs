using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamecanvasmanager : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Yourtrolledscreen;  
       
    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resumegame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
            PauseGame();
       }
    }

    public void Start()
    {        
        PauseMenu.SetActive(false);
        Yourtrolledscreen.SetActive(false);
    }    
}
