using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading;
using UnityEngine;
using WorldDumper.Formats;

namespace WorldDumper.Jsonl;

public static class Jsonler
{
private static readonly ConcurrentDictionary<string, Lazy<TextWriter>> Writers = new();

public static void Dump<T>(T data, string prefix)
{
    if (data == null) return;
    var path = Path.Combine(WorldDumperPlugin.LogsDir.Value, prefix + typeof(T).Name + ".jsonl");
    if (typeof(T) == typeof(VendingMachineFormat))
    {
        VendingMachineFormat f = (VendingMachineFormat)(object)data;
        foreach (VendingPurchaseFormat x in f.PurchaseArray) {
            WorldDumperPlugin.Beep.LogInfo($"Writing: PURCHASES {JsonUtility.ToJson(x)}");
        }
        WorldDumperPlugin.Beep.LogInfo($"Writing: {prefix + typeof(T).Name} :: {JsonUtility.ToJson(data)}");
    }
    WriteLine(path, JsonUtility.ToJson(data));
}

private static void WriteLine(string path, string line)
{
    var writer = Writers.GetOrAdd(path, CreateLazy).Value;
    writer.WriteLine(line);
}

private static Lazy<TextWriter> CreateLazy(string path) =>
    new(() =>
    {
        var fs = new FileStream(
            path,
            FileMode.Create,
            FileAccess.Write,
            FileShare.ReadWrite);

        var sw = new StreamWriter(fs, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false), 64 * 1024)
        {
            AutoFlush = true,
            NewLine = "\n"
        };
        return TextWriter.Synchronized(sw);
    }, LazyThreadSafetyMode.ExecutionAndPublication);

}
