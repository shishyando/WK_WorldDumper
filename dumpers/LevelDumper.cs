using HarmonyLib;
using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class LevelDumper
{
    public static readonly AccessTools.FieldRef<M_Level, bool> flippedRef = AccessTools.FieldRefAccess<M_Level, bool>("flipped");

    public static void Dump(M_Level lvl, string prefix)
    {   
        Jsonl.Jsonler.Dump(Get(lvl), prefix);
    }

    public static LevelFormat Get(M_Level lvl) {
        return new()
        {
            InstanceId = lvl.GetInstanceID(),
            LevelName = lvl.levelName,
            IsLastLevel = lvl.lastLevel,
            RegionName = lvl.region?.regionName ?? "no_region_name",
            SubregionName = lvl.subRegion?.subregionName ?? "no_subregion_name",
            Flipped = flippedRef(lvl),
            Seed = lvl.GetLevelSeed(),
            Active = lvl.gameObject.activeSelf,
        };
    }

    public static LevelFormat LevelOf(Transform tr)
    {
        M_Level parent = tr.GetComponentInParent<M_Level>(true);
        return parent ? Get(parent) : new();
    }
}
