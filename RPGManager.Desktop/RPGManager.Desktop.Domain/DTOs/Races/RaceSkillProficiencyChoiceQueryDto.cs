namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceSkillProficiencyChoiceQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceId { get; set; }
    public byte AllowedChoices { get; set; }
}
