using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class ItemDumper
{
    public static void Dump(Item it, string prefix)
    {
        ItemFormat f = new()
        {
            ItemName = it.itemName,
            ItemTag = it.itemTag,
            PrefabName = it.prefabName,
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
