using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public int level = 0;
    public int crosses = 0;
    public string file_name;
    
    public void SavePlayer()
    {
        save_and_load_progress.save(this);
    }

    public void LoadPlayer()
    {
        player_data data = save_and_load_progress.load();

        if(data.file_name == null)
        {
            Debug.LogError("file doesn't exist");
            return;
        }
        else
        {
            level = data.level;
            crosses = data.crosses_smashed;
            file_name = data.file_name;
        } 

        Debug.Log("Tried to load " + file_name);
    }
}
