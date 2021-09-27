using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.tvOS;

public class gamecanvasmanager : MonoBehaviour
{
    public InfoPanel PauseMenu;

    public void Update()
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

    public void Start()
    {
         
    }
}
