using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(UT_SpawnEntity), "Spawn")]
public static class UT_SpawnEntity_Spawn_Patcher
{
    [HarmonyPrefix]
    public static void Dump(UT_SpawnEntity __instance)
    {
        if (!WorldDumperPlugin.Playing) return;
        
        // Dump objects from randomizeObjects list if it exists
        if (__instance.randomizeObjects != null && __instance.randomizeObjects.Count > 0)
        {
            foreach (var randomObject in __instance.randomizeObjects)
            {
                if (randomObject != null)
                {
                    GameObjectDumper.Dump(randomObject, "UT_SpawnEntity_RandomizeObjects");
                }
            }
        }
        
        // Dump the main spawn object
        if (__instance.spawnObject != null)
        {
            GameObjectDumper.Dump(__instance.spawnObject, "UT_SpawnEntity_SpawnObject");
        }
    }
}


[HarmonyPatch(typeof(UT_SpawnEntity), "SpawnCustom")]
public static class UT_SpawnEntity_SpawnCustom_Patcher
{
    [HarmonyPrefix]
    public static void Dump(GameObject g)
    {
        if (WorldDumperPlugin.Playing && g != null)
        {
            GameObjectDumper.Dump(g, "UT_SpawnEntity_SpawnCustom");
        }
    }
}

