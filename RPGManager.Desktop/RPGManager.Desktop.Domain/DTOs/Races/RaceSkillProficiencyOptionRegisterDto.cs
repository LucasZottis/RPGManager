namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceSkillProficiencyOptionRegisterDto
{
    public Guid RaceSkillProficiencyChoiceId { get; set; }
    public Guid SkillId { get; set; }
    public bool IsExpertise { get; set; }
}
