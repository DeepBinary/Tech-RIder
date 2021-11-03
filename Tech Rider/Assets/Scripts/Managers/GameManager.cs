using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Coins;       

    private void Awake()
    {
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
        PlayerPrefs.SetInt("Coins", Coins);
    }

    public int GetCoins() 
    {
        return PlayerPrefs.GetInt("Coins");
    }

    public void AddCoins(int Amount) 
    {
        Coins += Amount;
        Save();
    }
    public void RemoveCoins(int Amount)
    {
        Coins -= Amount;
        Save();
    }
}
