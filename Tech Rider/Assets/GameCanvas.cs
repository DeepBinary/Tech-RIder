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
        ispaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            ispaused = true;
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            ispaused = false;
            PauseMenu.GetComponent<InfoPanel>().CloseDialog();
            Time.timeScale = 1f;
        }
    }
}
