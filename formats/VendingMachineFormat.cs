using System;
using System.Collections.Generic;
using System.Numerics;

namespace WorldDumper.Formats;

[Serializable]
public class VendingPurchaseFormat
{
    public string Name;
    public float Chance;
    public ItemFormat Item;
    public List<GameObjectFormat> spawnAssets;
    public int Price;
}

[Serializable]
public class VendingMachineFormat
{
    public string VendorId;
    public List<VendingPurchaseFormat> PurchaseList;
    public int LocalSeed;
    public Vector3 SpawnSpot;
    public bool RandomGeneration;
    public LevelFormat Level;
    public GameObjectFormat GameObject;
}
