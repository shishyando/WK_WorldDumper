using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(Item_Object), "Start")]
public static class Item_Object_Start_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(Item_Object __instance)
    {
        if (WorldDumperPlugin.Playing) ItemObjectDumper.Dump(__instance, "Item_Object_Start");
    }
}
