using System;

namespace WorldDumper.Formats;

[Serializable]
public class LevelFormat
{
    public string LevelName;
    public string RegionName;
    public string SubregionName;
    public int Seed;
    public bool IsLastLevel;
    public bool Flipped;
    public bool Active;
    public int InstanceId;
}
