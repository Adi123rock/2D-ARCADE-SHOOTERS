using System;
using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static string SavePath => Path.Combine(Application.persistentDataPath, "player.json");
    private static string TempPath => SavePath + ".tmp";

    public static void NewPlayer(SAVETRY data)
    {
        SavePlayer(data);
    }

    public static void SavePlayer(SAVETRY data)
    {
        if (data == null)
        {
            Debug.LogError("Cannot save player data because the data object is missing.");
            return;
        }

        try
        {
            string json = JsonUtility.ToJson(new Data(data), true);
            Directory.CreateDirectory(Application.persistentDataPath);
            File.WriteAllText(TempPath, json);
            if (File.Exists(SavePath))
                File.Replace(TempPath, SavePath, null);
            else
                File.Move(TempPath, SavePath);
        }
        catch (Exception exception)
        {
            Debug.LogError("Unable to save player data at " + SavePath + ": " + exception.Message);
            if (File.Exists(TempPath)) File.Delete(TempPath);
        }
    }

    public static Data LoadPlayer()
    {
        if (!File.Exists(SavePath)) return null;

        try
        {
            Data data = JsonUtility.FromJson<Data>(File.ReadAllText(SavePath));
            if (!IsValid(data))
            {
                Debug.LogWarning("Player save data is invalid. Starting with default progress.");
                return null;
            }
            return data;
        }
        catch (Exception exception)
        {
            Debug.LogWarning("Player save data could not be read. Starting with default progress: " + exception.Message);
            return null;
        }
    }

    public static void DeletePlayer(SAVETRY data)
    {
        try
        {
            if (File.Exists(SavePath)) File.Delete(SavePath);
            if (File.Exists(TempPath)) File.Delete(TempPath);
        }
        catch (Exception exception)
        {
            Debug.LogError("Unable to delete player data: " + exception.Message);
        }
    }

    private static bool IsValid(Data data)
    {
        return data != null && ValidPlayer(data.P1) && ValidPlayer(data.P2) && ValidPlayer(data.P3) &&
               ValidPlayer(data.P4) && ValidPlayer(data.P5) && ValidPlayer(data.P6) &&
               !float.IsNaN(data.coins) && !float.IsInfinity(data.coins) && data.coins >= 0 &&
               !float.IsNaN(data.diamonds) && !float.IsInfinity(data.diamonds) && data.diamonds >= 0 &&
               data.CompLvlno >= 0 && data.CompLvlno <= 5 &&
               (data.namespaceship == "S_1" || data.namespaceship == "S_2" || data.namespaceship == "S_3" ||
                data.namespaceship == "S_4" || data.namespaceship == "S_5" || data.namespaceship == "S_6");
    }

    private static bool ValidPlayer(player value)
    {
        return value != null && value.level > 0 && value.hp > 0 && value.dmg > 0 &&
               value.Upgcost >= 0 && value.Buycost >= 0;
    }
}
