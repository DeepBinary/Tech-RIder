using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerProgressUI : MonoBehaviour
{
    public TextMeshProUGUI coinstext;
    public PlayerDatahandler playerdatahandler;
    // Start is called before the first frame update
    void Start()
    {
        playerdatahandler.Load();
        Debug.Log(Application.persistentDataPath);
        coinstext.text = playerdatahandler.data.coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
