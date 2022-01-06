using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Demo : MonoBehaviour
{
    public int coins;
    public TextMeshProUGUI coinstext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinstext.text = coins.ToString();
    }

    public void LoadPlayerData()
    {
        PlayerData data = SavePlayerData.LoadPlayerData();

        coins = data.coins;
    }

    public void savePlayerData()
    {
        SavePlayerData.savePlayerData(this);
    }
}
