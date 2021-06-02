﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Uninstall : MonoBehaviour
{
    public void UninstallTrigger()
    {
        if (Directory.Exists("Backups"))
        {
            Directory.Delete("Backups",true);
        }
            Directory.CreateDirectory("Backups");

        if (Directory.Exists("Beat Saber/CustomSongs"))
            Directory.Move("Beat Saber/CustomSongs","Backups/CustomSongs");

        if (Directory.Exists("Beat Saber/CustomSabers"))
            Directory.Move("Beat Saber/CustomSabers","Backups/CustomSabers");

        if (Directory.Exists("Beat Saber/Beat Saber_Data/CustomLevels"))
            Directory.Move("Beat Saber/Beat Saber_Data/CustomLevels", "Backups/CustomLevels");

        if (Directory.Exists("Beat Saber/Beat Saber_Data/CustomWIPLevels"))
            Directory.Move("Beat Saber/Beat Saber_Data/CustomWIPLevels", "Backups/CustomWIPLevels");

        if (Directory.Exists("Beat Saber/UserData"))
            Directory.Move("Beat Saber/UserData", "Backups/UserData");

        if(Directory.Exists("Beat Saber/Plugins"))
            Directory.Move("Beat Saber/Plugins", $"Backups/{File.ReadAllText("BeatSaberVersion.txt")} Plugins");

        Directory.Delete("Beat Saber", true);

        if (File.Exists("BeatSaberVersion.txt"))
        {
            File.Delete("BeatSaberVersion.txt");
        }
    }
}