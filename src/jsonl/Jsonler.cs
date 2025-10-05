using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace WorldDumper.Jsonl;

public static class Jsonler
{
    private static readonly ConcurrentDictionary<string, Lazy<TextWriter>> Writers = new();
    private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, Formatting = Formatting.None, NullValueHandling = NullValueHandling.Include };

    public static void Dump<T>(T data, string prefix)
    {
        if (data == null) return;
        var path = Path.Combine(WorldDumperPlugin.LogsDir.Value, $"{prefix}_{typeof(T).Name}.jsonl");
        var json = JsonConvert.SerializeObject(data, SerializerSettings);
        WriteLine(path, json);
    }

    public static void DisposeWriters()
    {
        // I don't mind the race, DisposeWriters should not be called concurrently with anything
        foreach (var writer in Writers)
        {
            if (writer.Value.IsValueCreated) writer.Value.Value.Dispose();
        }
        if (WorldDumperPlugin.SortLogsAfterRun.Value)
        {
            foreach (string path in Writers.Keys)
            {
                var lines = File.ReadAllLines(path, Encoding.UTF8);
                Array.Sort(lines, StringComparer.Ordinal);
                File.WriteAllLines(path, lines, Encoding.UTF8);
            }
        }
        Writers.Clear();
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


