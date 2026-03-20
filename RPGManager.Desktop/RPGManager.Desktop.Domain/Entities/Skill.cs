namespace RPGManager.Desktop.Domain.Entities;

public class Skill : EntityBase
{
    public Guid GameSystemId { get; set; }
    public Guid BaseAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GameSystem GameSystem { get; set; }
    public Background BaseAbilityScore { get; set; }
}