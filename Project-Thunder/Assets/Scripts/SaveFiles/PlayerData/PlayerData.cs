using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int coins;
    public string PlayerName;
    public bool FirstTime;

    public PlayerData(PlayerData playerdata)
    {
        coins = playerdata.coins;
        PlayerName = playerdata.name;
        FirstTime = playerdata.FirstTime;
    }
}
