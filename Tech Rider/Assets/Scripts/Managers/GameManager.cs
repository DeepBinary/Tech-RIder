using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Coins;
    public int CoinsLocal;

    private void Awake()
    {
        CoinsLocal = 0;
        Coins = PlayerPrefs.GetInt("Coins");

        // Singleton pattern;
        int gamemanagercount = FindObjectsOfType<GameManager>().Length;

        if(gamemanagercount > 1)
        {
            Destroy(this.gameObject);
        }else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void Save() {
        Coins = Coins + CoinsLocal;
        PlayerPrefs.SetInt("Coins", Coins);
    }

    public int GetCoins() 
    {
        return PlayerPrefs.GetInt("Coins");
    }

    public void AddCoins(int Amount) 
    {
        CoinsLocal += Amount;
        Save();
    }
    public void RemoveCoins(int Amount)
    {
        CoinsLocal -= Amount;
        Save();
    }
}
