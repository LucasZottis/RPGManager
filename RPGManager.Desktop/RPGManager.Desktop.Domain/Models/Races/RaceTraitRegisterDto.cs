namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceTraitRegisterDto
{
    public Guid RaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? RequiredLevel { get; set; }
}
