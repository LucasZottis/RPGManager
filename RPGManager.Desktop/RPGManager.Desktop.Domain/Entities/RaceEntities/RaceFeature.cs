namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceFeature : EntityBase
{
    public Guid RaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}