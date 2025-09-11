using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(GameEntity), "Start")]
public static class GameEntity_Start_Patcher
{
    [HarmonyPostfix]
    public static void Dump(GameEntity __instance)
    {
        if (WorldDumperPlugin.Playing) GameEntityDumper.Dump(__instance, "GameEntity_Start");
    }
}
