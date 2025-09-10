using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(ENV_VendingMachine), "Start")]
public static class ENV_VendingMachine_Start_Patcher
{
    [HarmonyPostfix]
    public static void Dump(ENV_VendingMachine __instance)
    {
        try { VendingMachineDumper.Dump(__instance, "ENV_VendingMachine_Start_"); } catch (Exception e) { WorldDumperPlugin.Beep.LogError($"ENV_VendingMachine_Start_Patcher: {e}"); }

    }
}
