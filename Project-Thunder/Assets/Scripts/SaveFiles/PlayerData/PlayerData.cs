using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int ru;
    public string Playername;
    public int SpeedLevelIndex;
    public bool FirstTime;

    public PlayerData (GameManager manager)
    {
        ru = manager.ru;
        Playername = manager.playername;
        FirstTime = manager.firsttime;
        SpeedLevelIndex = manager.ShopUpgradeIndex;
    }
}
