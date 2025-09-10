using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class VendingMachineDumper
{
    public static readonly AccessTools.FieldRef<ENV_VendingMachine, int> localSeedRef = AccessTools.FieldRefAccess<ENV_VendingMachine, int>("localSeed");


    public static void Dump(ENV_VendingMachine vendo, string prefix)
    {
        WorldDumperPlugin.Beep.LogWarning($"vendo len {vendo.buttons.Length}, {string.Join("; ", Array.ConvertAll(vendo.buttons, x => { return x.purchase.name; }))}");

        VendingPurchaseFormat[] purchases = Array.ConvertAll(vendo.buttons, GetPurchase);
        foreach (var x in purchases)
        {
            WorldDumperPlugin.Beep.LogInfo($"dumping purchase: {JsonUtility.ToJson(x)}");
        }

        VendingMachineFormat f = new()
        {
            VendorId = vendo.vendorId,
            PurchaseArray = purchases,
            LocalSeed = localSeedRef(vendo),
            SpawnSpot = vendo.spawnSpot.position,
            RandomGeneration = vendo.randomGeneration,
            Level = LevelDumper.LevelOf(vendo.transform),
            GameObject = GameObjectDumper.Get(vendo.gameObject),
        };
        foreach (var x in f.PurchaseArray)
        {
            WorldDumperPlugin.Beep.LogInfo($"dumping purchase AFTER: {JsonUtility.ToJson(x)}");
        }
        Jsonl.Jsonler.Dump(f, prefix);
    }

    public static VendingPurchaseFormat GetPurchase(ENV_VendingMachine.VendingButton button)
    {
        return new()
        {
            Name = button.purchase.name,
            Chance = button.purchase.chance,
            Item = ItemObjectDumper.Get(button.purchase.itemObject),
            Price = button.purchase.price,
        };
    }
}
