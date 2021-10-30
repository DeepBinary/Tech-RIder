using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public TextMeshProUGUI Coinsstext;
    public CoinManager coinmanager;
    // Start is called before the first frame update
    void Start()
    {   
        coinmanager = FindObjectOfType<CoinManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Coinsstext.text = coinmanager.Coins.ToString();        
    }
}
