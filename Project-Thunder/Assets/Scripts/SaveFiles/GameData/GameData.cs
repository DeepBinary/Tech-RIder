using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public string name;
    public int ru;
    public int rankedPoints;
    public bool IsSignedIn;

    public GameData (AccountData data)
    {
        name = data.PlayerName;
        ru = data.ru;
        rankedPoints = data.rankedpoints;
        IsSignedIn = data.IsSigned;
    }
}
