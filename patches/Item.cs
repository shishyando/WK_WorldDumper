using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(Item), "GetClone")]
public static class Item_GetClone_Patcher
{
    [HarmonyPostfix]
    public static void Dump(Item __instance, Item __result)
    {
        try { ItemDumper.Dump(__result, "Item_GetClone_"); } catch (Exception e) { WorldDumperPlugin.Beep.LogError($"Item_GetClone_Patcher: {e}"); }
    }
}
