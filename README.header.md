# WorldDumper

Log everything in White Knuckle world. Writes .jsonl files with all events, entites, levels, etc. Keeps logs for the last two runs to diff them.

## Config

#### Directory
Directory to save logs to. Default is `BepInEx/WorldDumperOutput` for last run and `BepInEx/WorldDumperOutput_prev` for previous run.

#### LogGameObjectIds
Dump unique object ids (generated randomly for each object of each run independently). Default is `false`.

#### SortLogsAfterRun
Sort log lines (ascending, ordinal, case-sensitive). Default is `false` but it is useful for diffing (because the order of spawns may change for several reasons).
