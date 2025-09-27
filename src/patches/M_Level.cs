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
        if (WorldDumperPlugin.Playing) LevelDumper.Dump(__instance, "M_Level_Initialize");
    }
}
