using System;
using HarmonyLib;
using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class VendingMachineDumper
{
    public static readonly AccessTools.FieldRef<ENV_VendingMachine, int> localSeedRef = AccessTools.FieldRefAccess<ENV_VendingMachine, int>("localSeed");


    public static void Dump(ENV_VendingMachine vendo, string prefix)
    {
        VendingMachineFormat f = new()
        {
            VendorId = vendo.vendorId,
            PurchaseArray = Array.ConvertAll(vendo.buttons, GetPurchase),
            LocalSeed = localSeedRef(vendo),
            RandomGeneration = vendo.randomGeneration,
            Level = LevelDumper.LevelOf(vendo.transform),
            GameObject = GameObjectDumper.Get(vendo.gameObject),
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }

    public static VendingPurchaseFormat GetPurchase(ENV_VendingMachine.VendingButton button)
    {
        return new()
        {
            PrefabName = button.purchase.itemObject.name,
            Chance = button.purchase.chance,
            Price = button.purchase.price,
        };
    }
}
