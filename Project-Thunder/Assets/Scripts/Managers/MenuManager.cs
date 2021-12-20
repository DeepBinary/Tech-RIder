using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public MenuManager_Menu[] menus;
    void Start()
    {
        foreach (MenuManager_Menu menu in menus)
        {
            menu.menu.SetActive(false);

            if (menu.Main == true)
            {
                menu.menu.SetActive(true);
            }
        }
    }

    public void LoadMenu(int index)
    {
        foreach (MenuManager_Menu menu in menus)
        {
            menu.menu.SetActive(false);
        }
        menus[index].menu.SetActive(true);
    }

    public void CloseMenu()
    {
        foreach (MenuManager_Menu menu in menus)
        {
            
            menu.menu.SetActive(false);
            if (menu.Main == true)
            {
                menu.menu.SetActive(true);
            }
        }   
    }
}

[System.Serializable]
public class MenuManager_Menu 
{
    public GameObject menu;
    public bool Main;
}
