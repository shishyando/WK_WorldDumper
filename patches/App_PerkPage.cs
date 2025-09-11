using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(App_PerkPage), "Start")]
public static class App_PerkPage_Start_Patcher
{
    [HarmonyPostfix]
    public static void Dump(App_PerkPage __instance)
    {
        if (WorldDumperPlugin.Playing) PerkPageDumper.Dump(__instance, "App_PerkPage_Start");
    }
}
