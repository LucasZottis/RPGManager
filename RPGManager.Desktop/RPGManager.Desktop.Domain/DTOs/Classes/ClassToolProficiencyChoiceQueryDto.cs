namespace RPGManager.Desktop.Domain.DTOs.Classes;

public class ClassToolProficiencyChoiceQueryDto
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public byte AllowedChoices { get; set; }
}
