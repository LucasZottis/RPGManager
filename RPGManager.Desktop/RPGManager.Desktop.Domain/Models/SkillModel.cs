namespace RPGManager.Desktop.Domain.Models;

public class SkillModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    //public GameSystemModel GameSystem { get; set; }
    //public AbilityScoreModel BaseAbilityScore { get; set; }
}