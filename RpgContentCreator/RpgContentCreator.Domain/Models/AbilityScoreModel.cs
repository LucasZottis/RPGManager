namespace RpgContentCreator.Domain.Models;

public class AbilityScoreModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string Description { get; set; }

    public GameSystemModel GameSystem { get; set; }
    public ICollection<SkillModel> Skills { get; set; } = [];
}