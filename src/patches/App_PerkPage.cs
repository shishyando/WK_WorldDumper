using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(App_PerkPage), "GenerateCards", [typeof(bool)])]
public static class App_PerkPage_GenerateCards_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(bool refresh, App_PerkPage __instance)
    {
        if (WorldDumperPlugin.Playing) PerkPageDumper.Dump(__instance, "App_PerkPage_GenerateCards", refresh);
    }
}
