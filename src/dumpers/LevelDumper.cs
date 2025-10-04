using HarmonyLib;
using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class LevelDumper
{
    public static readonly AccessTools.FieldRef<M_Level, bool> flippedRef = AccessTools.FieldRefAccess<M_Level, bool>("flipped");

    public static void Dump(M_Level lvl, string prefix)
    {
        Jsonl.Jsonler.Dump(FormatLevel(lvl), prefix);
    }

    public static LevelFormat FormatLevel(M_Level lvl) {
        return new()
        {
            InstanceId = WorldDumperPlugin.LogGameObjectIds.Value ? lvl.GetInstanceID() : 0,
            LevelName = lvl.levelName,
            IsLastLevel = lvl.lastLevel,
            RegionName = lvl.region?.regionName ?? "no_region_name",
            SubregionName = lvl.subRegion?.subregionName ?? "no_subregion_name",
            Flipped = flippedRef(lvl),
            Seed = lvl.GetLevelSeed(),
            Active = lvl.gameObject.activeSelf,
        };
    }

    public static LevelFormat FormatLevelOf(Transform tr)
    {
        M_Level parent = LevelOf(tr);
        return parent ? FormatLevel(parent) : null;
    }

    public static M_Level LevelOf(Transform tr)
    {
        if (tr == null) return null;
        return tr.GetComponentInParent<M_Level>(true);
    }
}
