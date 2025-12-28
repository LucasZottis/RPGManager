namespace RPGManager.Desktop.Domain.Entities;

public class DamageType : EntityBase
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }

    public GameSystem GameSystem { get; set; }
}