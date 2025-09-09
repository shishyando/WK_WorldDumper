using System;

namespace WorldDumper.Formats;

[Serializable]
public class PerkFormat
{
	public App_PerkPage.PerkPageType perkPageType;

	public List<App_PerkPage_Card> cards;

	public string id;

}
