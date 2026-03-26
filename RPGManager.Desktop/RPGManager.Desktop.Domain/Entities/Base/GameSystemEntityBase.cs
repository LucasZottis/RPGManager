using RPGManager.Desktop.Domain.Entities.GameSystems;

namespace RPGManager.Desktop.Domain.Entities.Base;

public class GameSystemVersionEntityBase : EntityBase
{
    public Guid GameSystemVersionId { get; set; }

    public GameSystemVersion GameSystemVersion { get; set; }
}