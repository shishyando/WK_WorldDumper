using HarmonyLib;
using WorldDumper.Formats;

namespace WorldDumper.Dumpers;

public static class VendingMachineDumper
{
    public static void Dump(ENV_VendingMachine obj, string prefix)
    {
        VendingMachineFormat f = new()
        {
            
        };
        Jsonl.Jsonler.Dump(f, prefix);
    }
}
