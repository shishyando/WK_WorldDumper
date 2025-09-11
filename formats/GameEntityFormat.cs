using System;

namespace WorldDumper.Formats;

[Serializable]
public class GameEntityFormat
{
    public string EntityID;
    public string EntityType;
    public string Tag;
    public Position3 Position;
    public LevelFormat Level;
    public GameObjectFormat GameObject;
}
