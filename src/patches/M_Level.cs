using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(M_Level), "Initialize")]
public static class M_Level_Initialize_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(M_Level __instance)
    {
        if (WorldDumperPlugin.Playing) LevelDumper.Dump(__instance, "M_Level_Initialize");
    }
}
