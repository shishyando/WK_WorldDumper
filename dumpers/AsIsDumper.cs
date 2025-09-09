namespace WorldDumper.Dumpers;

public static class AsIsDumper
{
    public static void Dump<T>(T obj, string preifx)
    {
        Jsonl.Jsonler.Dump(obj, preifx);
    }
}
