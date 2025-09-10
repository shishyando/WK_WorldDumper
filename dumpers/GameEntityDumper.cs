using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class GameEntityDumper
{
    public static void Dump(GameEntity e, string prefix)
    {
        GameEntityFormat f = new()
        {
            Data = e.GetEntitySaveData(),
            Level = LevelDumper.LevelOf(e.transform),
            GameObject = GameObjectDumper.Get(e.gameObject),
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
