# WorldDumper

Log everything in White Knuckle world. Writes .jsonl files with all events, entites, levels, etc. Keeps logs for the last two runs to diff them.

## Config

#### Directory
Directory to save logs to. Default is `BepInEx/WorldDumperOutput` for last run and `BepInEx/WorldDumperOutput_prev` for previous run.

#### LogGameObjectIds
Dump unique object ids (generated randomly for each object of each run independently). Default is `false`.

#### SortLogsAfterRun
Sort log lines (ascending, ordinal, case-sensitive). Default is `false` but it is useful for diffing (because the order of spawns may change for several reasons).
## Table of Contents

- [Artifact](#artifact)
- [Denizen](#denizen)
- [Event](#event)
- [Item Object](#item-object)
- [Level](#level)
- [Object Spawner](#object-spawner)
- [Perk](#perk)
- [Pickupable](#pickupable)
- [Platform](#platform)
- [Spawn Chance](#spawn-chance)
- [Untagged](#untagged)
- [Vending Machine](#vending-machine)

## Examples

### Artifact
```json
{
    "PrefabName": "Item_Artifact_EVAGlove",
    "ItemName": "Artifact Glove",
    "ItemTag": "",
    "GameObject": {
        "Name": "Item_Artifact_EVAGlove(Clone)",
        "ParentName": "<root>",
        "Path": "Item_Artifact_EVAGlove(Clone)",
        "Position": {
            "x": -94.4717255,
            "y": 2235.11523,
            "z": 78.6537552
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "Level": {
        "LevelName": "M3_Habitation_Lab_Ending",
        "RegionName": "abyss",
        "SubregionName": "Transit Scaffolds",
        "Seed": 30093,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    }
}
```

### Denizen
```json
{
    "EntityID": "Denizen_Barnacle_Harpoon",
    "GameObject": {
        "Name": "Denizen_Barnacle_Harpoon(Clone)",
        "ParentName": "Spawn_Denizen_Barnacle_Harpoon",
        "Path": "Campaign-root/World_Root(Clone)/M4_Abyss_Garden_02(Clone)/Entities/Denizens/Spawn_Denizen_Barnacle_Harpoon/Denizen_Barnacle_Harpoon(Clone)",
        "Position": {
            "x": -389.533325,
            "y": 2164.631,
            "z": -1153.9281
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "EntityType": "barnacle",
    "Tag": "Denizen",
    "Position": {
        "x": -389.533325,
        "y": 2164.631,
        "z": -1153.9281
    },
    "Level": {
        "LevelName": "M4_Abyss_Garden_02",
        "RegionName": "abyss",
        "SubregionName": "hanging-garden",
        "Seed": 7117,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    }
}
```

### Event
```json
{
    "Id": "SessionEvent_Abyss_Nuke",
    "StartCheck": "startOfRegion",
    "EventModules": [
        "Spawn Nuke",
        "",
        "stopaftertime"
    ],
    "StartLevel": {
        "LevelName": "M4_Abyss_Garden_04",
        "RegionName": "abyss",
        "SubregionName": "hanging-garden",
        "Seed": 5119,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    }
}
```

### Item Object
```json
{
    "PrefabName": "Item_Floppy_T1_RandomItem",
    "ItemName": "Floppy Disk",
    "ItemTag": "disk",
    "GameObject": {
        "Name": "Item_Floppy_T1_RandomItem",
        "ParentName": "M1_Silos_Broken_01(Clone)",
        "Path": "Campaign-root/World_Root(Clone)/M1_Silos_Broken_01(Clone)/Item_Floppy_T1_RandomItem",
        "Position": {
            "x": 2.95286441,
            "y": 420.6212,
            "z": -36.8124466
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "Level": {
        "LevelName": "M1_Silos_Broken_01",
        "RegionName": "silos",
        "SubregionName": "Chambers",
        "Seed": 8115,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    }
}
```

### Level
```json
{
    "LevelName": "Campaign_Interlude_Pipeworks_To_Habitation_01",
    "RegionName": "habitation",
    "SubregionName": "Service Shaft",
    "Seed": 19104,
    "IsLastLevel": false,
    "Flipped": false,
    "Active": true,
    "InstanceId": 0
}
```

### Object Spawner
```json
{
    "Name": "UT_ExplosionSpawner",
    "ParentName": "Explosions",
    "Path": "Campaign-root/World_Root(Clone)/M3_Habitation_Lab_Ending(Clone)/Rho/Prop_Rho_ArtifactDevice_01/Explosions/UT_ExplosionSpawner",
    "Position": {
        "x": -88.52034,
        "y": 2238.142,
        "z": 82.41657
    },
    "Active": true,
    "InstanceId": 0,
    "SiblingIdx": 0
}
```

### Perk
```json
{
    "PerkPageType": "regular",
    "PerkCards": [
        {
            "Name": "Perk_Card(Clone)",
            "PerkInfo": {
                "Title": "Velocity Augments",
                "Description": "<color=\"grey\">+ </color>Improves Walking/Running speed by 25%\n<color=\"grey\">+ </color>Improves Climbing speed by 10%",
                "Id": "Perk_VelocityAugments",
                "Cost": 0,
                "SpawnPool": "standard"
            }
        },
        {
            "Name": "Perk_Card(Clone)",
            "PerkInfo": {
                "Title": "Portable Bank",
                "Description": "<color=\"grey\">+ </color>Roaches are automatically banked when placed in your bag.",
                "Id": "Perk_PortableBank",
                "Cost": 0,
                "SpawnPool": "standard"
            }
        },
        {
            "Name": "Perk_Card(Clone)",
            "PerkInfo": {
                "Title": "Elastic Limbs",
                "Description": "<color=\"grey\">+ </color>Increases Reach by 50%",
                "Id": "Perk_ElasticLimbs",
                "Cost": 12,
                "SpawnPool": "standard"
            }
        }
    ],
    "GameObject": {
        "Name": "Perks & Upgrades",
        "ParentName": "Apps",
        "Path": "OSManager(Clone)/OS/Computer Canvas/OS Panel/OS_Interactive_Group/Apps/Perks & Upgrades",
        "Position": {
            "x": 400.0,
            "y": 225.0,
            "z": 0.0
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "AfterRefresh": true,
    "Seed": -1
}
```

### Pickupable
```json
{
    "EntityID": "Item_Artifact_Rebar_Return",
    "GameObject": {
        "Name": "Item_Artifact_Rebar_Return(Clone)",
        "ParentName": "<root>",
        "Path": "Item_Artifact_Rebar_Return(Clone)",
        "Position": {
            "x": -96.08035,
            "y": 2235.12573,
            "z": 82.06044
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "EntityType": "entity",
    "Tag": "Pickupable",
    "Position": {
        "x": -96.08035,
        "y": 2235.12573,
        "z": 82.06044
    },
    "Level": null
}
```

### Platform
```json
{
    "EntityID": "Denizen_Gasbag",
    "GameObject": {
        "Name": "Denizen_Gasbag.03",
        "ParentName": "Entities",
        "Path": "Campaign-root/World_Root(Clone)/M2_Pipeworks_Waste_01(Clone)/Entities/Denizen_Gasbag.03",
        "Position": {
            "x": -172.15451,
            "y": 812.6783,
            "z": 95.82179
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "EntityType": "gasbag",
    "Tag": "Platform",
    "Position": {
        "x": -172.15451,
        "y": 812.6783,
        "z": 95.82179
    },
    "Level": {
        "LevelName": "M2_Pipeworks_Waste_01",
        "RegionName": "pipeworks",
        "SubregionName": "Waste Heap",
        "Seed": 15108,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    }
}
```

### Spawn Chance
```json
{
    "Name": "Event_MovingSecurityZone",
    "ParentName": "M3_Habitation_Lab_02(Clone)",
    "Path": "Campaign-root/World_Root(Clone)/M3_Habitation_Lab_02(Clone)/Event_MovingSecurityZone",
    "Position": {
        "x": -56.5981,
        "y": 2181.54858,
        "z": 81.09658
    },
    "Active": false,
    "InstanceId": 0,
    "SiblingIdx": 0
}
```

### Untagged
```json
{
    "EntityID": "Prop_BookcaseMedium_03",
    "GameObject": {
        "Name": "Prop_BookcaseMedium_02_001",
        "ParentName": "Props",
        "Path": "Campaign-root/World_Root(Clone)/M3_Habitation_Lab_Lobby(Clone)/Level_Main/Entities (1)/Props/Prop_BookcaseMedium_02_001",
        "Position": {
            "x": -46.21158,
            "y": 1874.29614,
            "z": 42.8206863
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    },
    "EntityType": "entity",
    "Tag": "Untagged",
    "Position": {
        "x": -46.21158,
        "y": 1874.29614,
        "z": 42.8206863
    },
    "Level": {
        "LevelName": "M3_Habitation_Lab_Lobby",
        "RegionName": "habitation",
        "SubregionName": "Delta Labs",
        "Seed": 26097,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    }
}
```

### Vending Machine
```json
{
    "VendorId": "abyss01",
    "PurchaseArray": [
        {
            "PrefabName": "Item_Beans",
            "Chance": 1.0,
            "Price": 2
        },
        {
            "PrefabName": "Item_Rubble",
            "Chance": 1.0,
            "Price": 1
        },
        {
            "PrefabName": "Item_Rebar",
            "Chance": 1.0,
            "Price": 3
        },
        {
            "PrefabName": "Item_Rebar_Explosive",
            "Chance": 0.8,
            "Price": 6
        },
        {
            "PrefabName": "Item_Rebar_Explosive",
            "Chance": 0.8,
            "Price": 6
        },
        {
            "PrefabName": "Item_Flaregun",
            "Chance": 0.5,
            "Price": 8
        },
        {
            "PrefabName": "Item_Rebar",
            "Chance": 1.0,
            "Price": 3
        },
        {
            "PrefabName": "Denizen_SlugGrub",
            "Chance": 0.8,
            "Price": 7
        }
    ],
    "LocalSeed": -192207689,
    "RandomGeneration": true,
    "Level": {
        "LevelName": "Campaign_Interlude_Habitation_To_Abyss_01",
        "RegionName": "abyss",
        "SubregionName": "Transit Scaffolds",
        "Seed": 0,
        "IsLastLevel": false,
        "Flipped": false,
        "Active": true,
        "InstanceId": 0
    },
    "GameObject": {
        "Name": "Prop_VendingMachine_Big",
        "ParentName": "Entities (1)",
        "Path": "Campaign-root/World_Root(Clone)/Campaign_Interlude_Habitation_To_Abyss_01(Clone)/Interior/Entities (1)/Prop_VendingMachine_Big",
        "Position": {
            "x": -100.0635,
            "y": 2240.549,
            "z": 14.7720776
        },
        "Active": true,
        "InstanceId": 0,
        "SiblingIdx": 0
    }
}
```
