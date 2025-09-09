using System;
using System.Collections.Generic;
using System.Numerics;

namespace WorldDumper.Formats;


[Serializable]
public class PerkFormat
{
	public string Title;
	public string Id;
	public string Description;
	public int Cost;
	public string SpawnPool;
}

[Serializable]
public class PerkCardFormat
{
	public string Name;
	public int Cost;
	public PerkFormat PerkInfo;
}

[Serializable]
public class PerkPageFormat
{
	public string PerkPageType;
	public List<PerkCardFormat> PerkCards;
	public string Id;
	public string Path;
	public Vector3 Postition;
	public bool Active;
	public LevelFormat Level;
	public GameObjectFormat GameObject;
}
