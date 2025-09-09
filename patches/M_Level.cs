using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(M_Level), "Initialize")]
public static class M_Level_Initialize_Patcher
{
    [HarmonyPostfix]
    public static void Dump(M_Level __instance)
    {
        // try { AsIsDumper.Dump(M_Level.SaveData.GetSave(__instance), "M_Level_Initialize_"); } catch (Exception e) { WorldDumperPlugin.Beep.LogError($"M_Level_Initialize_Patcher: {e}"); }
        try { LevelDumper.Dump(__instance, "M_Level_Initialize_"); } catch (Exception e) { WorldDumperPlugin.Beep.LogError($"M_Level_Initialize_Patcher: {e}"); }
    }
}
