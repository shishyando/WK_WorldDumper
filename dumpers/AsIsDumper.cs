namespace WorldDumper.Dumpers;

// for already Serializable data with a good out-of-the-box format
public static class AsIsDumper
{
    public static void Dump<T>(T obj, string preifx)
    {
        Jsonl.Jsonler.Dump(obj, preifx);
    }
}
