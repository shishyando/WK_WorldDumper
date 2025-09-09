using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class ItemDumper
{
    public static void Dump(Item_Object obj, string prefix)
    {
        Item it = obj.itemData;
        ItemFormat f = new()
        {
            InstanceId = obj.GetInstanceID(),
            ItemName = it.itemName,
            ItemTag = it.itemTag,
            PrefabName = it.prefabName,
            Position = obj?.transform.position ?? new(),
            Active = obj?.gameObject.activeSelf ?? false,
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
