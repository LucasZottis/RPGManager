using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.AuthEntities;

public class Role : EntityBase
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<UserRole> Users { get; set; }
}