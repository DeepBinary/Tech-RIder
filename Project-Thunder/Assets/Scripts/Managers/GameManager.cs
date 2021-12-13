using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coins;
    public int CoinsEarned;

    private void Awake()
    {
        CoinsEarned = 0;
        coins = PlayerPrefs.GetInt("Coins");

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
        coins = coins + CoinsEarned;
        PlayerPrefs.SetInt("Coins", coins);
    }

    public int GetCoins() 
    {
        return PlayerPrefs.GetInt("Coins");
    }

    public void AddCoins(int Amount) 
    {
        CoinsEarned += Amount;
    }
    public void RemoveCoins(int Amount)
    {
        CoinsEarned -= Amount;
    }

    public void ResetManager()
    {
        CoinsEarned = 0;
    }
}
