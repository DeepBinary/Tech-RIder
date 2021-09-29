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
          if(Input.GetKeyDown(KeyCode.Escape))
          {
               ShrinkBorder border = FindObjectOfType<ShrinkBorder>().GetComponent<ShrinkBorder>();
               border.isshrinking = false;
               PauseMenu.gameObject.SetActive(true);
          }

          if (PauseMenu.WindowActive == false)
          {
               ShrinkBorder border = FindObjectOfType<ShrinkBorder>().GetComponent<ShrinkBorder>();
               border.isshrinking = true;
          }
    }

    private void Start()
    {
         
    }
}
