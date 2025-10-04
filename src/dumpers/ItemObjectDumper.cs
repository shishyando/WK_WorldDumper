using WorldDumper.Formats;
namespace WorldDumper.Dumpers;

public static class ItemObjectDumper
{
    public static void Dump(Item_Object obj, string prefix, UnityEngine.Transform customTr = null, bool dumpGameObject = true)
    {
        Jsonl.Jsonler.Dump(FormatItemObject(obj, customTr, dumpGameObject), prefix);
    }

    public static ItemObjectFormat FormatItemObject(Item_Object it, UnityEngine.Transform customTr = null, bool dumpGameObject = false)
    {
        return new()
        {
            ItemName = it.itemData.itemName,
            ItemTag = it.itemData.itemTag,
            PrefabName = it.itemData.prefabName,
            GameObject = dumpGameObject ? GameObjectDumper.FormatGameObject(it.gameObject) : null,
            Level = LevelDumper.FormatLevelOf(customTr) ?? LevelDumper.FormatLevelOf(it.transform) ?? null,
        };
    }
}
