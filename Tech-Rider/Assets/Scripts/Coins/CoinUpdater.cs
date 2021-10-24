using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUpdater : MonoBehaviour
{
    
    public TextMeshProUGUI CoinsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        CoinsText.text = FindObjectOfType<CoinManager>().Coins.ToString();
    }
}
