namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? ParentRaceId { get; set; } = null;
    public string Name { get; set; }
    public string? Description { get; set; }
    public float Speed { get; set; }
}