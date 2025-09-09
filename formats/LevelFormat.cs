using System;

namespace WorldDumper.Formats;

[Serializable]
public class LevelFormat
{
    public int InstanceId;
    public string LevelName;
    public string RegionName;
    public string SubregionName;
    public bool IsLastLevel;
    public bool Flipped;
    public int Seed;
    public bool Active;
}
