using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUpdater : MonoBehaviour
{
    public TextMeshProUGUI CoinsText;
    void Update()
    {
        CoinsText.text = FindObjectOfType<GameManager>().Coins.ToString();
    }
}
