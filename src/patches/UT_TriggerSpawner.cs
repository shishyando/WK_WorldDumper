using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(UT_TriggerSpawner), "Spawn")]
public static class UT_TriggerSpawner_Spawn_Patcher
{
    [HarmonyPrefix]
    public static void Dump(UT_TriggerSpawner __instance)
    {
        if (!WorldDumperPlugin.Playing) return;
        
        // Dump objects from spawn table if it exists
        if (__instance.spawnTable != null)
        {
            try
            {
                var spawnObject = __instance.spawnTable.GetRandomSpawnObject();
                if (spawnObject != null)
                {
                    var prefab = spawnObject.GetRandomPrefab();
                    if (prefab != null)
                    {
                        GameObjectDumper.Dump(prefab, "UT_TriggerSpawner_SpawnTable");
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogWarning($"Failed to dump spawn table object: {ex.Message}");
            }
        }
        
        // Dump objects from spawn objects list
        if (__instance.spawnObjects != null && __instance.spawnObjects.Count > 0)
        {
            foreach (var spawnObject in __instance.spawnObjects)
            {
                if (spawnObject != null)
                {
                    GameObjectDumper.Dump(spawnObject, "UT_TriggerSpawner_SpawnObjects");
                }
            }
        }
    }
}

