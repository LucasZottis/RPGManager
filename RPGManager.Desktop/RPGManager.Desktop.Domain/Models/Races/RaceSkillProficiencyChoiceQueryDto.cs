namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceSkillProficiencyChoiceQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceId { get; set; }
    public byte AllowedChoices { get; set; }
}
