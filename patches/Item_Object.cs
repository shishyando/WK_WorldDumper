using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(Item_Object), "Start")]
public static class Item_Object_Start_Patcher
{
    [HarmonyPostfix]
    public static void Dump(Item_Object __instance)
    {
        try { ItemObjectDumper.Dump(__instance, "Item_Object_Start_"); } catch (Exception e) { WorldDumperPlugin.Beep.LogError($"Item_Object_Start_Patcher: {e}"); }
    }
}
