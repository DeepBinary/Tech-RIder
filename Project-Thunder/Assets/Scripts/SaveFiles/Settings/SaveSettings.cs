using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSettings 
{
   public static void SaveSettingsData (SettingsMenu settings)
   {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/settings.pog";
        FileStream stream = new FileStream(path, FileMode.Create);

        SettingsData data = new SettingsData(settings);

        formatter.Serialize(stream, data);
        stream.Close();
   }

    public static SettingsData LoadSettingsData()
    {
        string path = Application.persistentDataPath + "/settings.pog";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SettingsData data = formatter.Deserialize(stream) as SettingsData;
            stream.Close();

            return data;
            
        } else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
