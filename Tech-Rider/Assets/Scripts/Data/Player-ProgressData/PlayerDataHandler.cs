using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerDataHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerDataHandler.Start");
        PlayerData data = new PlayerData();
        data.coins = 100;

        string json = JsonUtility.ToJson(data);
        Debug.Log(json);

        File.WriteAllText(Application.dataPath + "/playerData.json", json);

        //PlayerData loadedPlayerdata = JsonUtility.FromJson<PlayerData>(json);
        //Debug.Log("Coinds : " + loadedPlayerdata.coins);
    }

    private class PlayerData 
    {
        public int coins;
    }
}
