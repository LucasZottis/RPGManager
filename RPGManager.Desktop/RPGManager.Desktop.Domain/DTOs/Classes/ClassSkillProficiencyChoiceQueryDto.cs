namespace RPGManager.Desktop.Domain.DTOs.Classes;

public class ClassSkillProficiencyChoiceQueryDto
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public byte AllowedChoices { get; set; }
}
