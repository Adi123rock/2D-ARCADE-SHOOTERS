using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void NewPlayer(SAVETRY data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        Data data1 = new Data(data);
        formatter.Serialize(stream, data1);
        stream.Close();
    }
    public static void SavePlayer(SAVETRY data)
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Data data1 = new Data(data);
            formatter.Serialize(stream, data1);
            stream.Close();
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
        }
    }
    public static Data LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Data data1 = formatter.Deserialize(stream) as Data;
            stream.Close();
            return data1;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    public static void DeletePlayer(SAVETRY data)
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Data data1 = new Data(data,"Delete");
            formatter.Serialize(stream, data1);
            stream.Close();
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
        }
    }

}
