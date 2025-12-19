namespace RpgContentCreator.Application.Models;

public class SkillModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GameSystemModel GameSystem { get; set; }
    public AbilityScoreModel BaseAbilityScore { get; set; }
}