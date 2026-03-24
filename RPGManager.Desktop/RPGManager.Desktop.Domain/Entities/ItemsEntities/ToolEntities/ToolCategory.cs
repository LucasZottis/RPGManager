using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

public class ToolCategory : EntityBase
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }

    public GameSystem GameSystem { get; set; }
}