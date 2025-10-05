using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class GameObjectDumper
{
    public static void Dump(GameObject obj, string prefix)
    {
        Jsonl.Jsonler.Dump(FormatGameObject(obj), prefix);
    }

    public static GameObjectFormat FormatGameObject(GameObject obj)
    {
        return new()
        {
            Name = obj.name,
            Position = new(obj.transform),
            ParentName = obj.transform.parent?.gameObject?.name ?? "<root>",
            Path = GetPath(obj.transform),
            Active = obj.activeSelf,
            InstanceId = WorldDumperPlugin.LogGameObjectIds.Value ? obj.GetInstanceID() : 0,
            SiblingIdx = WorldDumperPlugin.LogGameObjectIds.Value ? obj.transform.GetSiblingIndex() : 0,
        };
    }

    private static string GetPath(Transform t)
    {
        System.Text.StringBuilder sb = new(t.name);
        for (Transform p = t.parent; p != null; p = p.parent)
            sb.Insert(0, p.name + "/");
        return sb.ToString();
    }

}
