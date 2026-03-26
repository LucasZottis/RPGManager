namespace RPGManager.Desktop.Domain.Models.AbilityScores;

public class AbilityScoreRegisterDto
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public string? Description { get; set; }
}
