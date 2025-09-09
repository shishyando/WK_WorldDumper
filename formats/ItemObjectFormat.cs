using System;
using UnityEngine;

namespace WorldDumper.Formats;

[Serializable]
public class ItemObjectFormat
{
    public string PrefabName;
    public string ItemName;
    public string ItemTag;
    public LevelFormat Level;
    public GameObjectFormat GameObject;
}
