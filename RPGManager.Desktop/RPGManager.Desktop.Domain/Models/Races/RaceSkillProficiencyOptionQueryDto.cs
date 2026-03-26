namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceSkillProficiencyOptionQueryDto
{
    public Guid RaceSkillProficiencyChoiceId { get; set; }
    public Guid SkillId { get; set; }
    public bool IsExpertise { get; set; }
}
