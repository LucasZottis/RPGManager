namespace RPGManager.Desktop.Application.DTOs.Races;

public class RaceQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public Guid? ParentRaceId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public float Speed { get; set; }
}