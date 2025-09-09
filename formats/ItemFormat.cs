using System;
using UnityEngine;

namespace WorldDumper.Formats;

[Serializable]
public class ItemFormat
{
    public int InstanceId;
    public string ItemName;
    public string ItemTag;
    public string PrefabName;
    public Vector3 Position;
    public bool Active;
    public LevelFormat Level;
}
