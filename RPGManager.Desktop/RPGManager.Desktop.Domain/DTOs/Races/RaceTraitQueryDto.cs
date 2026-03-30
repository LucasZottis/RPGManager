namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceTraitQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? RequiredLevel { get; set; }
}
