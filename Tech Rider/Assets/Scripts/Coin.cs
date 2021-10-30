using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public int CoinsRewarded;
    private Manager gamemanager;
    void Start()
    {
        gamemanager = FindObjectOfType<Manager>();
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
        gamemanager.Score += CoinsRewarded;
        Destroy(this.gameObject);
    }
}
