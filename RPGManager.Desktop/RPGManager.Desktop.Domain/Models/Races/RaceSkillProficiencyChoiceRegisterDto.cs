namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceSkillProficiencyChoiceRegisterDto
{
    public Guid RaceId { get; set; }
    public byte AllowedChoices { get; set; }
}
