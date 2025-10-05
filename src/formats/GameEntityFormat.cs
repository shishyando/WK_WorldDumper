using System;

namespace WorldDumper.Formats;

[Serializable]
public class GameEntityFormat
{
    public string EntityID;
    public GameObjectFormat GameObject;
    public string EntityType;
    public string Tag;
    public Position3 Position;
    public LevelFormat Level;
}
