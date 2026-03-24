namespace RPGManager.Desktop.Domain.Entities.Base;

public class GameSystemEntityBase : EntityBase
{
    public Guid GameSystemId { get; set; }

    public GameSystem GameSystem { get; set; }
}