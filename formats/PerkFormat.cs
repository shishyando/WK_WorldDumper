using System;
using System.Collections.Generic;
using System.Numerics;

namespace WorldDumper.Formats;


[Serializable]
public class PerkPageFormat
{
	public string PerkPageType;
	public List<PerkCardFormat> PerkCards;
	public string Id;
	public LevelFormat Level;
	public GameObjectFormat GameObject;
}

[Serializable]
public class PerkCardFormat
{
	public string Name;
	public PerkFormat PerkInfo;
}

[Serializable]
public class PerkFormat
{
	public string Title;
	public string Id;
	public string Description;
	public int Cost;
	public string SpawnPool;
}
