using System;
using UnityEngine;

namespace WorldDumper.Formats;

[Serializable]
public class GameEntityFormat
{
    public GameEntity.BaseEntitySaveData Data;
    public LevelFormat Level;
    public GameObjectFormat GameObject;
}
