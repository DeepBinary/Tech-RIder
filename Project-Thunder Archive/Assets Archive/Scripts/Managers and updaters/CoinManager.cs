using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int Coins;

    private void Awake()
    {
        Coins = PlayerPrefs.GetInt("Coins");
        int Coinmanagercoint = FindObjectsOfType<CoinManager>().Length;

        if(Coinmanagercoint > 1)
        {
            Destroy(gameObject);
        }else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    public void Doyouwinscreeenstuf()
    {
        Coins += FindObjectOfType<Manager>().Score;
        PlayerPrefs.SetInt("Coins", Coins);
    }


    public void Update()
    {
        PlayerPrefs.SetInt("Coins", Coins);
    }
}
