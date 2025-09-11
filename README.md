# WorldDumper

Log everything in White Knuckle world.

## Table of Contents

- [Vending Machine](#vending-machine)
- [Denizen](#denizen)
- [Pickupable](#pickupable)
- [Item](#item)
- [Level](#level)
- [Event](#event)
- [Perk](#perk)

## Examples

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
        "InstanceId": -57772,
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
        "InstanceId": -61854,
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
        "InstanceId": -57772,
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

### Item
```json
{
    "PrefabName": "Item_RebarRope",
    "ItemName": "Rebar",
    "ItemTag": "rebar",
    "Level": {
        "InstanceId": -39054,
        "LevelName": "M1_Silos_Storage_11",
        "RegionName": "silos",
        "SubregionName": "Deep Storage",
        "IsLastLevel": false,
        "Flipped": false,
        "Seed": 1999,
        "Active": true
    },
    "GameObject": {
        "InstanceId": 0,
        "Name": "Item_RebarRope",
        "Active": true,
        "ParentName": "Items",
        "Path": "Campaign-root/World_Root(Clone)/M1_Silos_Storage_11(Clone)/Entities (1)/Items/Item_RebarRope",
        "Position": {
            "x": 9.245653,
            "y": 93.28429,
            "z": -2.48516417
        },
        "SiblingIdx": 0
    }
}
```

### Level
```json
{
    "InstanceId": -48666,
    "LevelName": "M1_Silos_Air_01",
    "RegionName": "silos",
    "SubregionName": "Ventilation",
    "IsLastLevel": false,
    "Flipped": true,
    "Seed": 5995,
    "Active": true
}
```

### Event
Logged when happen

### Perk
Perks are generated when you access the computer page with perks
