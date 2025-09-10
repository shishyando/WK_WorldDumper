using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(SessionEvent), "StartEvent")]
public static class SessionEvent_StartEvent_Patcher
{
    [HarmonyPostfix]
    public static void Dump(SessionEvent __instance)
    {
        try { SessionEventDumper.Dump(__instance, "SessionEvent_StartEvent_"); } catch (Exception e) { WorldDumperPlugin.Beep.LogError($"SessionEvent_StartEvent_Patcher: {e}"); }
    }
}
