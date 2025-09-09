using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.IO;

namespace WorldDumper;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class WorldDumperPlugin : BaseUnityPlugin
{

    internal static WorldDumperPlugin Instance;
    internal static ManualLogSource Beep;
    private Harmony Harmony;

    // Config
    public static ConfigEntry<string> LogsDir;

    private void Awake()
    {
        Instance = this;
        Beep = Logger;
        LogsDir = Config.Bind("Logging", "Directory", Path.Combine(Paths.BepInExRootPath, $"{MyPluginInfo.PLUGIN_NAME}Output"), $"Directory for {MyPluginInfo.PLUGIN_NAME} logs");
        try
        {
            DirectoryInfo cur = Directory.CreateDirectory(LogsDir.Value);
            string old = LogsDir.Value + "_old";
            Directory.CreateDirectory(old);
            foreach (FileInfo file in cur.GetFiles())
            {
                file.CopyTo(Path.Combine(old, file.Name));
            }
        }
        catch (Exception e)
        {
            Beep.LogError($"Recreating logs directory failed: {e}");
            return;
        }

        Harmony = new(MyPluginInfo.PLUGIN_GUID);
        Harmony.PatchAll();
        // Harmony.PatchAll(typeof(Patches.Item_Object_Start_Patcher));
        // Harmony.PatchAll(typeof(Patches.M_Level_OnSpawn_Patcher));
        // Harmony.PatchAll(typeof(Patches.UT_SpawnChance_Start_Patcher));
        // Harmony.PatchAll(typeof(Patches.UT_SPT_Spawner_Spawn_Patcher));
        // Harmony.PatchAll(typeof(Patches.SpawnTableAsset_GetEffectiveSpawnChance_Patcher));
        Beep.LogInfo($"{MyPluginInfo.PLUGIN_GUID} is loaded");
    }
}
