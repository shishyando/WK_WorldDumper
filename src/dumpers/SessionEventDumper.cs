using HarmonyLib;
using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class SessionEventDumper
{
    public static readonly AccessTools.FieldRef<SessionEvent, M_Level> startLevelRef = AccessTools.FieldRefAccess<SessionEvent, M_Level>("startLevel");
    public static void Dump(SessionEvent e, string prefix)
    {
        SessionEventFormat f = new()
        {
            Id = e.id,
            StartCheck = nameof(e.startCheck),
            EventModules = e.modules.ConvertAll(x => { return x.name; }),
            StartLevel = LevelDumper.Get(startLevelRef(e)),
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
