using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class GameObjectDumper
{
    public static void Dump(GameObject obj, string prefix)
    {
        Jsonl.Jsonler.Dump(Get(obj), prefix);
    }

    public static GameObjectFormat Get(GameObject obj)
    {
        return new()
        {
            InstanceId = obj.GetInstanceID(),
            Name = obj.name,
            Active = obj.activeSelf,
            ParentName = obj.transform.parent?.gameObject?.name ?? "<root>",
            Path = GetPath(obj.transform),
            Position = obj.transform.position,
            SiblingIdx = obj.transform.GetSiblingIndex(),
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
