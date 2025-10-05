using System;
using HarmonyLib;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(UT_RadiusSpawner), "Spawn")]
public static class UT_RadiusSpawner_Spawn_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(UT_RadiusSpawner __instance)
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
                        GameObjectDumper.Dump(prefab, "UT_RadiusSpawner_SpawnTable");
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
                    GameObjectDumper.Dump(spawnObject, "UT_RadiusSpawner_SpawnObjects");
                }
            }
        }
    }
}
