using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class DataGameSave
{
    public static DataGameInit data;

    public static void Init()
    {
        data = JsonUtility.FromJson<DataGameInit>(File.ReadAllText(Application.dataPath));
        if (data == null)
        {
            //create
            data = new DataGameInit();
            Save();
        }
    }
    public static void Save()
    {
        File.WriteAllText(Application.dataPath, JsonUtility.ToJson(data));
    }
    public static void Load()
    {
        data = JsonUtility.FromJson<DataGameInit>(File.ReadAllText(Application.dataPath));
    }
}
