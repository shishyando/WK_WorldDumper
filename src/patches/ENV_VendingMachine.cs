using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(ENV_VendingMachine), "GenerateOptions")]
public static class ENV_VendingMachine_GenerateOptions_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(ENV_VendingMachine __instance)
    {
        if (WorldDumperPlugin.Playing) VendingMachineDumper.Dump(__instance, "ENV_VendingMachine_GenerateOptions");
    }
}
