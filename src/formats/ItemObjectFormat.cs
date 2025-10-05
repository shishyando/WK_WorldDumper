using System;

namespace WorldDumper.Formats;

[Serializable]
public class ItemObjectFormat
{
    public string PrefabName;
    public string ItemName;
    public string ItemTag;
    public GameObjectFormat GameObject;
    public LevelFormat Level;
}
