using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class ItemObjectDumper
{
    public static void Dump(Item_Object obj, string prefix)
    {
        Jsonl.Jsonler.Dump(Get(obj), prefix);
    }

    public static ItemObjectFormat Get(Item_Object it)
    {
        return new() {
            ItemName = it.itemData.itemName,
            ItemTag = it.itemData.itemTag,
            PrefabName = it.itemData.prefabName,
            GameObject = GameObjectDumper.Get(it.gameObject),
            Level = LevelDumper.LevelOf(it.transform)
        };
    }
}
