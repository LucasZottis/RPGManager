using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities;

public class Alignment : EntityBase
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GameSystem GameSystem { get; set; }
}