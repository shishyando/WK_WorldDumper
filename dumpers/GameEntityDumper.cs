using System;
using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class GameEntityDumper
{
    public static void Dump(GameEntity e, string prefix)
    {
        GameEntityFormat f = new()
        {
            EntityID = e.entityPrefabID,
            EntityType = e.objectType,
            Tag = e.tag,
            Position = new(e.gameObject.transform),
            Level = LevelDumper.LevelOf(e.transform),
            GameObject = GameObjectDumper.Get(e.gameObject),
        };
        Jsonl.Jsonler.Dump(f, $"{prefix}_{e.tag}");
    }
}
