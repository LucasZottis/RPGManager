namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class ArmorCategory : EntityBase
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public GameSystem GameSystem { get; set; }
}