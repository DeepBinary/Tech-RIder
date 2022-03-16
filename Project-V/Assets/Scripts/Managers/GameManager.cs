using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int ru;
    public int Earnedru;
    public int charge;
    public string playername;
    public bool firsttime;
    public int mainmenuSceneIndex;
    public GameObject playerprefab;
    private bool ismainmenu;

    void Start()
    {
        #region MainMenuCheck
        //if (SceneManager.GetActiveScene().buildIndex == mainmenuSceneIndex)
        //{
        //ismainmenu = true;
        //} else
        //{
        //ismainmenu = false;
        //}
        #endregion

        if (File.Exists(Application.persistentDataPath + "/PlayerData.pog"))
        {
            LoadPlayerData();
        } else
        {
            ru = 0;
            firsttime = true;
        }


        Earnedru = 0;
    }

    void Update()
    {
        if (firsttime == true)
        {
            if (ismainmenu)
            {
                
            }
        }
    }

    public void savePlayerData()
    {
        SavePlayerData.SavePlayer(this);
    }

    public void LoadPlayerData()
    {
        PlayerData data = SavePlayerData.LoadPlayer();
        ru = data.ru;
        playername = data.Playername;
        firsttime = data.FirstTime;
    }

    public void Register(TMP_InputField Inputfield)
    {
        playername = Inputfield.text;
        firsttime = false;
        savePlayerData();
    }

    public void WrapUpLevel()
    {
        ru += Earnedru;
        Earnedru = 0;
        savePlayerData();
    }
}