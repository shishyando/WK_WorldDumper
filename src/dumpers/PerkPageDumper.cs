using System.Collections.Generic;
using HarmonyLib;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class PerkPageDumper
{
    public static readonly AccessTools.FieldRef<App_PerkPage, List<App_PerkPage_Card>> cardsRef = AccessTools.FieldRefAccess<App_PerkPage, List<App_PerkPage_Card>>("cards");

    public static void Dump(App_PerkPage page, string prefix)
    {
        PerkPageFormat f = new()
        {
            PerkPageType = nameof(page.perkPageType),
            PerkCards = cardsRef(page).ConvertAll(ConvertPerkCard),
            GameObject = GameObjectDumper.FormatGameObject(page.gameObject)
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }

    public static PerkCardFormat ConvertPerkCard(App_PerkPage_Card card)
    {
        return new()
        {
            Name = card.name,
            PerkInfo = FormatPerk(card.perk),
        };
    }

    public static PerkFormat FormatPerk(Perk perk) {
        return new()
        {
            Title = perk.GetTitle(),
            Description = perk.GetDescription(),
            Cost = perk.cost,
            SpawnPool = nameof(perk.spawnPool),
        };
    }
}
