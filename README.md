# WorldDumper

Log everything in White Knuckle world. Writes .jsonl files with all events, entites, levels, etc. Keeps logs for the last two runs to diff them.
## Table of Contents

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

### Denizen
```json
{
    "EntityID": "Denizen_Bloodbug",
    "EntityType": "bloodbug",
    "Tag": "Denizen",
    "Position": {
        "x": -0.164804012,
        "y": 723.070251,
        "z": 105.436058
    },
    "Level": {
        "InstanceId": 0,
        "LevelName": "M2_Pipeworks_Drainage_05",
        "RegionName": "pipeworks",
        "SubregionName": "Drainage System",
        "IsLastLevel": false,
        "Flipped": false,
        "Seed": 9991,
        "Active": true
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Denizen_Bloodbug(Clone)",
        "Active": true,
        "ParentName": "Entities",
        "Path": "Campaign-root/World_Root(Clone)/M2_Pipeworks_Drainage_05(Clone)/Entities/Denizen_Bloodbug(Clone)",
        "Position": {
            "x": -0.164804012,
            "y": 723.070251,
            "z": 105.436058
        },
        "SiblingIdx": 0
    }
}
```

### Event
```json
{
    "Id": "SessionEvent_Abyss_Nuke",
    "StartCheck": "startCheck",
    "EventModules": [
        "Spawn Nuke",
        "",
        "stopaftertime"
    ],
    "StartLevel": {
        "InstanceId": 0,
        "LevelName": "M4_Abyss_Garden_01",
        "RegionName": "abyss",
        "SubregionName": "hanging-garden",
        "IsLastLevel": false,
        "Flipped": true,
        "Seed": 4419984,
        "Active": true
    }
}
```

### Item Object
```json
{
    "Comment": "a bit different from pickupable entity, you may find it useful",
    "PrefabName": "Item_Artifact_Rebar_Return",
    "ItemName": "Rebar",
    "ItemTag": "rebar",
    "Level": {
        "InstanceId": 0,
        "LevelName": null,
        "RegionName": null,
        "SubregionName": null,
        "IsLastLevel": false,
        "Flipped": false,
        "Seed": 0,
        "Active": false
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Item_Artifact_Rebar_Return(Clone)",
        "Active": true,
        "ParentName": "<root>",
        "Path": "Item_Artifact_Rebar_Return(Clone)",
        "Position": {
            "x": 101.855057,
            "y": 2193.49658,
            "z": 197.684357
        },
        "SiblingIdx": 0
    }
}
```

### Level
```json
{
    "InstanceId": 0,
    "LevelName": "M1_Silos_Air_01",
    "RegionName": "silos",
    "SubregionName": "Ventilation",
    "IsLastLevel": false,
    "Flipped": true,
    "Seed": 5995,
    "Active": true
}
```

### Object Spawner
```json
{
    "InstanceId": 0,
    "Name": "UT_ExplosionSpawner.01",
    "Active": true,
    "ParentName": "Explosions",
    "Path": "Campaign-root/World_Root(Clone)/M3_Habitation_Lab_Ending(Clone)/Rho/Prop_Rho_ArtifactDevice_01/Explosions/UT_ExplosionSpawner.01",
    "Position": {
        "x": 106.533989,
        "y": 2195.58765,
        "z": 199.9173
    },
    "SiblingIdx": 0
}
```

### Perk
```json
{
    "PerkPageType": "perkPageType",
    "PerkCards": [
        {
            "Name": "Perk_Card(Clone)",
            "PerkInfo": {
                "Title": "Teleporter Malfunction",
                "Id": "Perk_U_TX_TeleporterMalfunction",
                "Description": "Trapped in the moment between your birth and your death.",
                "Cost": 0,
                "SpawnPool": "spawnPool"
            }
        },
        {
            "Name": "Perk_Card(Clone)",
            "PerkInfo": {
                "Title": "Disk Jockey",
                "Id": "Perk_U_T2_DiskJockey",
                "Description": "We thought you might need the help.",
                "Cost": 0,
                "SpawnPool": "spawnPool"
            }
        }
    ],
    "GameObject": {
        "InstanceId": 0,
        "Name": "Experimental Perks",
        "Active": true,
        "ParentName": "Apps",
        "Path": "OSManager_SingleApp(Clone)/OS/Computer Canvas/OS Panel/OS_Interactive_Group/Apps/Experimental Perks",
        "Position": {
            "x": 400.0,
            "y": 225.0,
            "z": 0.0
        },
        "SiblingIdx": 0
    }
}
```

### Pickupable
```json
{
    "EntityID": "Prop_Radio",
    "EntityType": "entity",
    "Tag": "Pickupable",
    "Position": {
        "x": -4.360544,
        "y": 661.131958,
        "z": 32.9430847
    },
    "Level": {
        "InstanceId": 0,
        "LevelName": "M1_Campaign_Transition_Silo_To_Pipeworks_01",
        "RegionName": "pipeworks",
        "SubregionName": "Ventilation",
        "IsLastLevel": false,
        "Flipped": false,
        "Seed": 8992,
        "Active": true
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Prop_Radio",
        "Active": true,
        "ParentName": "Props",
        "Path": "Campaign-root/World_Root(Clone)/M1_Campaign_Transition_Silo_To_Pipeworks_01(Clone)/Entities (1)/Props/Prop_Radio",
        "Position": {
            "x": -4.360544,
            "y": 661.131958,
            "z": 32.9430847
        },
        "SiblingIdx": 0
    }
}
```

### Platform
```json
{
    "EntityID": "Denizen_Gasbag",
    "EntityType": "gasbag",
    "Tag": "Platform",
    "Position": {
        "x": 64.83247,
        "y": 998.0472,
        "z": 121.786179
    },
    "Level": {
        "InstanceId": 0,
        "LevelName": "M2_Pipeworks_Waste_01",
        "RegionName": "pipeworks",
        "SubregionName": "Waste Heap",
        "IsLastLevel": false,
        "Flipped": false,
        "Seed": 4428974,
        "Active": true
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Denizen_Gasbag.02",
        "Active": true,
        "ParentName": "Entities",
        "Path": "Campaign-root/World_Root(Clone)/M2_Pipeworks_Waste_01(Clone)/Entities/Denizen_Gasbag.02",
        "Position": {
            "x": 64.83247,
            "y": 998.0472,
            "z": 121.786179
        },
        "SiblingIdx": 0
    }
}
```

### Spawn Chance
```json
{
    "Comment": "most things that are spawned randomly on the ground",
    "InstanceId": 0,
    "Name": "Handhold-Basic",
    "Active": true,
    "ParentName": "Level-Handhold-Root",
    "Path": "Campaign-root/World_Root(Clone)/M1_Silos_Storage_05(Clone)/M1_Basic_05/Level_Hull/Level-Handhold-Root/Handhold-Basic",
    "Position": {
        "x": -1.76303768,
        "y": 26.3244343,
        "z": 6.310929
    },
    "SiblingIdx": 0
}
```

### Untagged
```json
{
    "EntityID": "Prop_FlareCrate_01",
    "EntityType": "entity",
    "Tag": "Untagged",
    "Position": {
        "x": 130.611588,
        "y": 2126.386,
        "z": -116.402061
    },
    "Level": {
        "InstanceId": 0,
        "LevelName": "M4_Abyss_Transit_05",
        "RegionName": "abyss",
        "SubregionName": "transit-scaffolds",
        "IsLastLevel": false,
        "Flipped": true,
        "Seed": 4415988,
        "Active": true
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Prop_FlareCrate_01(Clone)",
        "Active": true,
        "ParentName": "Spawn_Prop_FlareCrate_01",
        "Path": "Campaign-root/World_Root(Clone)/M4_Abyss_Transit_05(Clone)/Entities/Items/Spawn_Prop_FlareCrate_01/Prop_FlareCrate_01(Clone)",
        "Position": {
            "x": 130.611588,
            "y": 2126.386,
            "z": -116.402061
        },
        "SiblingIdx": 0
    }
}
```

### Vending Machine
```json
{
    "VendorId": "vend01",
    "PurchaseArray": [
        {
            "PrefabName": "Item_RebarRope",
            "Chance": 1.0,
            "Price": 5
        },
        {
            "PrefabName": "Item_Flaregun",
            "Chance": 0.5,
            "Price": 8
        },
        {
            "PrefabName": "Item_Beans",
            "Chance": 1.0,
            "Price": 2
        }
    ],
    "LocalSeed": 8992,
    "RandomGeneration": true,
    "Level": {
        "InstanceId": 0,
        "LevelName": "M1_Campaign_Transition_Silo_To_Pipeworks_01",
        "RegionName": "pipeworks",
        "SubregionName": "Ventilation",
        "IsLastLevel": false,
        "Flipped": false,
        "Seed": 8992,
        "Active": true
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Prop_VendingMachine.01",
        "Active": true,
        "ParentName": "Props",
        "Path": "Campaign-root/World_Root(Clone)/M1_Campaign_Transition_Silo_To_Pipeworks_01(Clone)/Entities (1)/Props/Prop_VendingMachine.01",
        "Position": {
            "x": -5.86,
            "y": 656.067139,
            "z": 10.8999109
        },
        "SiblingIdx": 0
    }
}
```
