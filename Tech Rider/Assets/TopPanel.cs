using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPanel : MonoBehaviour
{
    public GameObject[] Menus;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject menu in Menus)
        {
            menu.gameObject.SetActive(false);
        }
    }

    public void OpenMenu(int index)
    {
        foreach (GameObject menu in Menus)
        {
            menu.gameObject.SetActive(false);
        }

        Menus[index].SetActive(true);
    }
}
