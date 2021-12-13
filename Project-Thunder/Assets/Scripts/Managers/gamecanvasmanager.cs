using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameCanvasManager : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Update()
    {
        ShrinkBorder border = FindObjectOfType<ShrinkBorder>().GetComponent<ShrinkBorder>();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            border.isshrinking = false;
            PauseMenu.gameObject.SetActive(true);
        }
    }

    private void Start()
    {
        PauseMenu.SetActive(false);
    }
}
