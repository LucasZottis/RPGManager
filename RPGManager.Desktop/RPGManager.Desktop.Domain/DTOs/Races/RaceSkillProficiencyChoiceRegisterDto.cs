namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceSkillProficiencyChoiceRegisterDto
{
    public Guid RaceId { get; set; }
    public byte AllowedChoices { get; set; }
}
