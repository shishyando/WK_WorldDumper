using System;
using System.Collections;
using HarmonyLib;
using UnityEngine;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(UT_SPT_Spawner), "Spawn")]
public static class UT_SPT_Spawner_Spawn_Patcher
{
    [HarmonyPrefix]
    public static void Dump(UT_SPT_Spawner __instance)
    {
        if (!WorldDumperPlugin.Playing) return;
        
        // Dump objects from spawn table if it exists
        if (__instance.spawnTable != null)
        {
            try
            {
                var randomSpawnObject = __instance.spawnTable.GetRandomSpawnObject();
                if (randomSpawnObject != null && randomSpawnObject.prefabs != null)
                {
                    var prefab = randomSpawnObject.GetRandomPrefab();
                    if (prefab != null)
                    {
                        GameObjectDumper.Dump(prefab, "UT_SPT_Spawner_SpawnTable");
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogWarning($"Failed to dump spawn table object: {ex.Message}");
            }
        }
    }
}

