namespace RPGManager.Desktop.Domain.Models.Classes;

public class ClassSkillProficiencyChoiceRegisterDto
{
    public Guid ClassId { get; set; }
    public byte AllowedChoices { get; set; }
}
