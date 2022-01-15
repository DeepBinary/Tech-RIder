using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int ru;
    public int Earnedru;
    public int charge;
    public string playername;
    public bool firsttime;
    public bool ismainmenu;
    public GameObject playerprefab;    

    void Start()
    {      

        if (File.Exists(Application.persistentDataPath + "/PlayerData.pog"))
        {
            LoadPlayerData();
        } 
        
        else
        {
            ru = 0;
            firsttime = true;
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
        Earnedru = 0;
        savePlayerData();
    }   

    public IEnumerator EnableObjectinDelay(GameObject obj, float delay)
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
    }
}


[System.Serializable]
public class Upgrade
{
    public int cost;
    public float UpgradedStats;
}
