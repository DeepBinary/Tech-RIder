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

    [Header("Upgrades")]
    public Button UgradeButton;
    public TextMeshProUGUI speedtext, costText;
    public GameObject playerprefab;
    public SpeedUpgrade[] Levels;
    public int ShopUpgradeIndex;
    public int maxplayerspeed;

    public GameObject[] purchasefeedback;

    void Start()
    { 
        if (ismainmenu)
        {
            if(playerprefab.GetComponent<PlayerMovement>().speed >= maxplayerspeed)
            {
                ShopUpgradeIndex = Levels.Length;
                UgradeButton.interactable = false;
            }

            foreach (GameObject feedback in purchasefeedback)
            {
                feedback.SetActive(false);
            }

            if (playerprefab.GetComponent<PlayerMovement>().speed < maxplayerspeed)
            {
                costText.text = "Cost : " + Levels[ShopUpgradeIndex].cost.ToString();
            }

            speedtext.text = playerprefab.GetComponent<PlayerMovement>().speed.ToString() + " / " + "100";
        }

        if (File.Exists(Application.persistentDataPath + "/PlayerData.pog"))
        {
            LoadPlayerData();
        } else
        {
            ShopUpgradeIndex = 0;
        }
        Earnedru = 0;
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.B))
        {
            ru += 69696969;
            savePlayerData();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            playerprefab.GetComponent<PlayerMovement>().speed = 35;
            ShopUpgradeIndex = 0;
            savePlayerData();
        }
        if (ismainmenu)
        {
            if (playerprefab.GetComponent<PlayerMovement>().speed >= maxplayerspeed)
            {
                UgradeButton.interactable = false;
                ShopUpgradeIndex = Levels.Length;
            }
            if (playerprefab.GetComponent<PlayerMovement>().speed < maxplayerspeed)
            {
                UgradeButton.interactable = true;
            }

            speedtext.text = playerprefab.GetComponent<PlayerMovement>().speed.ToString() + " / " + "100";
            
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
        ShopUpgradeIndex = data.SpeedLevelIndex;
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

    public void Upgrade()
    {
        LoadPlayerData();        
        if (Levels[ShopUpgradeIndex].cost <= ru)
        {
            if (playerprefab.GetComponent<PlayerMovement>().speed >= maxplayerspeed)
            {
                UgradeButton.interactable = false;
            }
            if (playerprefab.GetComponent<PlayerMovement>().speed < maxplayerspeed)
            {
                costText.text = "Cost : " + Levels[ShopUpgradeIndex].cost.ToString();
                speedtext.text = playerprefab.GetComponent<PlayerMovement>().speed.ToString() + " / " + "100";
                ru -= Levels[ShopUpgradeIndex].cost;
                playerprefab.GetComponent<PlayerMovement>().speed = Levels[ShopUpgradeIndex].speed;
                StartCoroutine(EnableObjectinDelay(purchasefeedback[0], 1));
                ShopUpgradeIndex++;
                savePlayerData();                
            }

        } else
        {
            StartCoroutine(EnableObjectinDelay(purchasefeedback[1], 1));
            UgradeButton.interactable = false;
        }
        
    }

    public IEnumerator EnableObjectinDelay(GameObject obj, float delay)
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
    }
}


[System.Serializable]
public class SpeedUpgrade
{
    public int cost;
    public float speed;
}
