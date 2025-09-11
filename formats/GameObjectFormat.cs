using System;

namespace WorldDumper.Formats;

[Serializable]
public class GameObjectFormat
{
    public int InstanceId;
    public string Name;
    public bool Active;
    public string ParentName;
    public string Path;
    public Position3 Position;
    public int SiblingIdx;
}
