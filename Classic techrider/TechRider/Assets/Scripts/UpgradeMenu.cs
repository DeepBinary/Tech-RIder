using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeMenu : MonoBehaviour
{
    public ShopManager shopManager;
    public CoinManager coinManager;
    public TextMeshProUGUI speedcostText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpgradeCarSpeed(int Upgradeaddition)
    {
        shopManager.carblueprints[shopManager.currentcarindex].speed += Upgradeaddition;
    }

    public void PurchaseSped(int cost = 500)
    {
        speedcostText.text = cost.ToString();
        PlayerPrefs.SetInt("Cost", cost);
        coinManager.Coins -= cost;
        cost += 50;
        cost = PlayerPrefs.GetInt("Cost");
        speedcostText.text = cost.ToString();
    }
}
