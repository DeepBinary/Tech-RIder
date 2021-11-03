using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public int CoinsRewarded;
    private GameManager gamemanager;
    void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            RewardCoins();
        }
    }
    public void RewardCoins()
    {
        gamemanager.Coins += CoinsRewarded;
        Destroy(this.gameObject);
    }
}
