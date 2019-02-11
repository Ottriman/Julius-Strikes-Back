using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public static class save_and_load_progress {

    public static void save(player player_chosen)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        player_data data = new player_data(player_chosen);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static player_data load()
    {
        string path = Application.persistentDataPath + "/player.txt";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            player_data data = formatter.Deserialize(stream) as player_data;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Error, file not found at " + path);
            return null;
        }
    }
}
