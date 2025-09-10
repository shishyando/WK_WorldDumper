using System;
using System.Collections.Generic;
using UnityEngine;

namespace WorldDumper.Formats;

[Serializable]
public class VendingPurchaseFormat
{
    public string Name;
    public float Chance;
    public ItemObjectFormat Item;
    public int Price;
}

[Serializable]
public class VendingMachineFormat
{
    public string VendorId;
    public VendingPurchaseFormat[] PurchaseArray;
    public int LocalSeed;
    public Vector3 SpawnSpot;
    public bool RandomGeneration;
    public LevelFormat Level;
    public GameObjectFormat GameObject;
}
