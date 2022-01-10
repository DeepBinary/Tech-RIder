using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int ru;
    public int Earnedru;
    public int charge;
    public string playername;
    public bool firsttime;
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerData.pog"))
        {
            LoadPlayerData();
        }
        Earnedru = 0;
    }

    void Update()
    {
        
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
        savePlayerData();
    }
}
