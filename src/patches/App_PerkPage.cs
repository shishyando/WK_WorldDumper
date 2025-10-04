using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(App_PerkPage), "GenerateCards", [typeof(bool)])]
public static class App_PerkPage_GenerateCards_Patcher
{
    [HarmonyPostfix]
    public static void Dump(bool refresh, App_PerkPage __instance)
    {
        if (WorldDumperPlugin.Playing) PerkPageDumper.Dump(__instance, "App_PerkPage_GenerateCards", refresh);
    }
}
