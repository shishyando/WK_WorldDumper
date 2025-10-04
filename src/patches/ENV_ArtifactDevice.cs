using System;
using System.Collections.Generic;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(ENV_ArtifactDevice), "Start")]
public static class ENV_ArtifactDevice_Start_Patcher
{
    public static readonly AccessTools.FieldRef<ENV_ArtifactDevice, List<Item_Object>> spawnedArtifactsRef = AccessTools.FieldRefAccess<ENV_ArtifactDevice, List<Item_Object>>("spawnedArtifacts");

    [HarmonyPostfix]
    public static void Dump(ENV_ArtifactDevice __instance)
    {
        if (WorldDumperPlugin.Playing) {
            foreach (var art in spawnedArtifactsRef(__instance)) {
                ItemObjectDumper.Dump(art, "ENV_ArtifactDevice_Start", __instance.transform);
            }
        }
    }
}
