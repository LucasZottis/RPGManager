using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class Feature : GameSystemEntityBase
{
    public string Name { get; set; }
    public string? Description { get; set; }
}