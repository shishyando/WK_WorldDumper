using System;
using System.Collections.Generic;

namespace WorldDumper.Formats;


[Serializable]
public class PerkPageFormat
{
	public string PerkPageType;
	public List<PerkCardFormat> PerkCards;
	public GameObjectFormat GameObject;
	public bool AfterRefresh;
	public int Seed;
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
	public string Description;
	public string Id;
	public int Cost;
	public string SpawnPool;
}
