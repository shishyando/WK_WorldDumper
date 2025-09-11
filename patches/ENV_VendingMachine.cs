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
        if (WorldDumperPlugin.Playing) VendingMachineDumper.Dump(__instance, "ENV_VendingMachine_Start");
    }
}
