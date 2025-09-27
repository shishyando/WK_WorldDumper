using System;

namespace WorldDumper.Formats;

[Serializable]
public class VendingPurchaseFormat
{
    public string PrefabName;
    public float Chance;
    public int Price;
}

[Serializable]
public class VendingMachineFormat
{
    public string VendorId;
    public VendingPurchaseFormat[] PurchaseArray;
    public int LocalSeed;
    public bool RandomGeneration;
    public LevelFormat Level;
    public GameObjectFormat GameObject;
}
