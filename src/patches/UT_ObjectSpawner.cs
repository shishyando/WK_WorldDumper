using HarmonyLib;
using UnityEngine;
using WorldDumper.Dumpers;

namespace WorldDumper.Patches;


[HarmonyPatch(typeof(UT_ObjectSpawner), "Spawn", [])]
public static class UT_ObjectSpawner_Spawn_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(UT_ObjectSpawner __instance)
    {
        if (WorldDumperPlugin.Playing) GameObjectDumper.Dump(__instance.gameObject, "UT_ObjectSpawner_Spawn");
    }
}


[HarmonyPatch(typeof(UT_ObjectSpawner), "Spawn", [typeof(UnityEngine.GameObject)])]
public static class UT_ObjectSpawner_SpawnGameObject_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(GameObject o)
    {
        if (WorldDumperPlugin.Playing) GameObjectDumper.Dump(o, "UT_ObjectSpawner_SpawnGameObject");
    }
}


[HarmonyPatch(typeof(UT_ObjectSpawner), "SpawnAtTransform")]
public static class UT_ObjectSpawner_SpawnAtTransform_Patcher
{
    [HarmonyPriority(Priority.Last)]
    public static void Finalizer(UT_ObjectSpawner __instance)
    {
        if (WorldDumperPlugin.Playing && __instance.spawnObject != null)
            GameObjectDumper.Dump(__instance.spawnObject, "UT_ObjectSpawner_SpawnAtTransform");
    }
}
