using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] menus;
    void Start()
    {
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
    }

    public void LoadMenu(int index)
    {
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }

        menus[index].SetActive(true);
    }

    public void CloseMenu()
    {
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
    }
}
