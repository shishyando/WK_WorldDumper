using System;

namespace WorldDumper.Formats;

[Serializable]
public class GameObjectFormat
{
    public string Name;
    public string ParentName;
    public string Path;
    public Position3 Position;
    public bool Active;
    public int InstanceId;
    public int SiblingIdx;
}
