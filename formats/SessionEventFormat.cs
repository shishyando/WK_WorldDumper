using System;
using System.Collections.Generic;
using UnityEngine;

namespace WorldDumper.Formats;

[Serializable]
public class SessionEventFormat
{
    public string Id;
    public string StartCheck;
    public List<string> EventModules;
    public LevelFormat StartLevel;
    // public SubregionFormat StartSubregion;
    // public RegionFormat StartRegion;
}
