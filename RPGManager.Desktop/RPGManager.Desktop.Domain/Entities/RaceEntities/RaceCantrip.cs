namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceCantrip
{
    public Guid SpellId { get; set; }
    public Guid RaceId { get; set; }

    public Race Race { get; set; }
}