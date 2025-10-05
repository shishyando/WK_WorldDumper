using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using WorldDumper.Jsonl;

namespace WorldDumper;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class WorldDumperPlugin : BaseUnityPlugin
{

    internal static WorldDumperPlugin Instance;
    internal static ManualLogSource Beep;
    private Harmony _harmony;
    public static bool Playing = false;

    // Config
    public static ConfigEntry<string> LogsDir;
    public static ConfigEntry<bool> LogGameObjectIds;
    public static ConfigEntry<bool> SortLogsAfterRun;

    private void Awake()
    {
        Instance = this;
        Beep = Logger;
        LogsDir = Config.Bind("Logging", "Directory", Path.Combine(Paths.BepInExRootPath, $"{MyPluginInfo.PLUGIN_NAME}Output"), $"Directory for {MyPluginInfo.PLUGIN_NAME} logs");
        LogGameObjectIds = Config.Bind("Logging", "LogGameObjectIds", false, $"If true, {MyPluginInfo.PLUGIN_NAME} will dump some unique ids (e.g. GameObject.InstanceID, GameObject.SiblingIdx) for game object formats");
        SortLogsAfterRun = Config.Bind("Logging", "SortLogsAfterRun", false, $"If true, {MyPluginInfo.PLUGIN_NAME} will sort the logs after the run (may be useful for diffing)");

        _harmony = new(MyPluginInfo.PLUGIN_GUID);
        Beep.LogInfo($"{MyPluginInfo.PLUGIN_GUID} is loaded");
        SceneManager.sceneUnloaded += OnSceneUnloaded;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Instance._harmony.PatchAll();
    }

    public void OnSceneLoaded(Scene s, LoadSceneMode m)
    {
        Beep.LogInfo($"OnSceneLoaded: {s.name} (mode: {m})");
        if (s.name == "Game-Main") Start();
    }

    public void OnSceneUnloaded(Scene s)
    {
        Beep.LogInfo($"OnSceneUnloaded: {s.name}");
        if (s.name == "Game-Main") Stop();
    }

    public static void Start()
    {
        if (TryToRotateLogs())
        {
            Playing = true;
        }
    }

    public static void Stop()
    {
        Playing = false;
        Jsonler.DisposeWriters();
    }

    public static bool TryToRotateLogs()
    {
        Jsonler.DisposeWriters();
        try
        {
            string prev = Path.Combine(Paths.BepInExRootPath, LogsDir.Value + "_prev");
            if (Directory.Exists(prev)) Directory.Delete(prev, true);
            if (!Directory.Exists(prev)) Directory.CreateDirectory(prev);
            DirectoryInfo cur = Directory.CreateDirectory(LogsDir.Value);
            foreach (FileInfo f in cur.EnumerateFiles())
            {
                f.MoveTo(Path.Combine(prev, f.Name));
            }
            return true;
        }
        catch (Exception e)
        {
            Beep.LogError($"Recreating logs directory failed: {e}");
            Stop();
            return false;
        }
    }

}
