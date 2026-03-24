namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceSizeOption
{
    public Guid RaceId { get; set; }
    public Guid SizeId { get; set; }

    public Race Race { get; set; }
    public Size Size { get; set; }
}