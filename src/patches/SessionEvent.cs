using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(SessionEvent), "StartEvent")]
public static class SessionEvent_StartEvent_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(SessionEvent __instance)
    {
        if (WorldDumperPlugin.Playing) SessionEventDumper.Dump(__instance, "SessionEvent_StartEvent");
    }
}
