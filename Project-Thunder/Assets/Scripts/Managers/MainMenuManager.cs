using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [Header("PlayerDetails")]
    public TextMeshProUGUI rutext;
    public TextMeshProUGUI nametext;
    public TMP_InputField inputfield;

    [Header("Register")]
    public GameObject RegisterMenu;
    public GameObject[] RegisterDisable;

    private GameManager manager;
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        if (!manager.firsttime)
        {
            manager.LoadPlayerData();            
        }
    }

    void Update()
    {
        nametext.text = manager.playername;
        rutext.text = manager.ru.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            manager.firsttime = true;
            manager.savePlayerData();
            FindObjectOfType<MenuManager>().CloseMenu();
        }

        if (manager.firsttime)
        {
            foreach (GameObject menu in RegisterDisable)
            {
                menu.SetActive(false);
            }
            RegisterMenu.SetActive(true);
        }
    }

    public void Register()
    {
        manager.Register(inputfield);
        foreach (GameObject menu in RegisterDisable)
        {
            menu.SetActive(true);
        }
        RegisterMenu.SetActive(false);
    }
}
