using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.GameSystems;

public class GameSystem : EntityBase
{
    public string Name { get; set; }
    public byte LevelLimit { get; set; }

    public ICollection<GameSystemVersion> Versions { get; set; } = [];
}