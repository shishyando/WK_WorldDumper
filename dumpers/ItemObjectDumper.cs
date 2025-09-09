using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class ItemObjectDumper
{
    public static void Dump(Item_Object obj, string prefix)
    {
        Item it = obj.itemData;
        ItemObjectFormat f = new()
        {
            ItemName = it.itemName,
            ItemTag = it.itemTag,
            PrefabName = it.prefabName,
            GameObject = GameObjectDumper.Get(obj.gameObject),
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
