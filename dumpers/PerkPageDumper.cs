using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class PerkPageDumper
{
    public static readonly AccessTools.FieldRef<App_PerkPage, List<App_PerkPage_Card>> cardsRef = AccessTools.FieldRefAccess<App_PerkPage, List<App_PerkPage_Card>>("cards");
    public static readonly AccessTools.FieldRef<App_PerkPage, string> idRef = AccessTools.FieldRefAccess<App_PerkPage, string>("id");

    public static void Dump(App_PerkPage page, string prefix)
    {
        PerkPageFormat f = new()
        {
            PerkPageType = nameof(page.perkPageType),
            PerkCards = cardsRef(page).ConvertAll(ConvertPerkCard),
            Id = idRef(page),
            Level = LevelDumper.LevelOf(page.transform),
            GameObject = GameObjectDumper.Get(page.gameObject)
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }

    public static PerkCardFormat ConvertPerkCard(App_PerkPage_Card card)
    {
        return new()
        {
            Name = card.name,
            PerkInfo = GetPerkInfo(card.perk),
        };
    }

    public static PerkFormat GetPerkInfo(Perk perk) {
        return new()
        {
            Title = perk.title,
            Id = perk.id,
            Description = perk.description,
            Cost = perk.cost,
            SpawnPool = nameof(perk.spawnPool),
        };
    }
}
