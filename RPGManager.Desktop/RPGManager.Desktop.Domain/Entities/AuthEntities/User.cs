using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.AuthEntities;

public class User : EntityBase
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public DateTime CreatedAt { get; set; }

    public IEnumerable<UserRole> Roles { get; set; }
}