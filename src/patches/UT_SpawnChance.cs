using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(UT_SpawnChance), "Start")]
public static class UT_SpawnChance_Start_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(UT_SpawnChance __instance)
    {
        if (WorldDumperPlugin.Playing) GameObjectDumper.Dump(__instance.gameObject, "UT_SpawnChance_Start");
    }
}
