using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
        ispaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (ispaused == false) 
            {
                EnterPause();
                return;
            }

            if (ispaused == true) 
            {
                ExitPause();
                return;
            }
        }
    }

    public void EnterPause() 
    {
        ispaused = true;
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }

    public void ExitPause() 
    {
        ispaused = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
