using HarmonyLib;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class LevelDumper
{
    public static readonly AccessTools.FieldRef<M_Level, bool> flippedRef = AccessTools.FieldRefAccess<M_Level, bool>("flipped");

    public static void Dump(M_Level obj, string prefix)
    {
        LevelFormat f = new()
        {
            InstanceId = obj.GetInstanceID(),
            LevelName = obj.levelName,
            IsLastLevel = obj.lastLevel,
            RegionName = obj.region?.regionName ?? "no_region_name",
            SubregionName = obj.subRegion?.subregionName ?? "no_subregion_name",
            Flipped = flippedRef(obj),
            Seed = obj.GetLevelSeed(),
            Active = obj.gameObject.activeSelf,
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
