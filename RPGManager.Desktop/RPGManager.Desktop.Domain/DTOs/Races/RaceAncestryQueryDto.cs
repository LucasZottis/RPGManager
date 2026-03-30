namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceAncestryQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
