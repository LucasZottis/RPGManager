namespace RPGManager.Desktop.Domain.DTOs.Skills;

public class SkillRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid BaseAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
