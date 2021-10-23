using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameCanvasManager : MonoBehaviour
{
    public InfoPanel PauseMenu;

    private void Update()
    {
        ShrinkBorder border = FindObjectOfType<ShrinkBorder>().GetComponent<ShrinkBorder>();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            border.isshrinking = false;
            PauseMenu.gameObject.SetActive(true);
        }

        if (PauseMenu.WindowActive == false)
        {               
            border.isshrinking = true;
        }
    }

    private void Start()
    {
         
    }
}
