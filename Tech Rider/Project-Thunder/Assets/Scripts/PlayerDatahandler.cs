using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDatahandler : MonoBehaviour
{
    public PlayerData data;
    public string file = "playerData.txt";

    public void Save()
    {
        string json = JsonUtility.ToJson(data);
        WriteToFile(file, json);
    }

    public void Load()
    {
        data = new PlayerData();
        string json = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(json, data);
    }

    private void WriteToFile (string filename, string json)
    {
        string path = GetFilePath(filename);
        FileStream filestream = new FileStream(path, FileMode.Create);

        using(StreamWriter writer = new StreamWriter(filestream))
        {
            writer.Write(json);
        }
    }

    private string ReadFromFile(string filename)
    {
        string path = GetFilePath(filename);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        } else
        {
            Debug.LogError("file not found");
        }

        return "";
    }

    private string GetFilePath(string filename)
    {
        return Application.persistentDataPath + "/" + filename;
    }
}
