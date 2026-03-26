namespace RPGManager.Desktop.Domain.Models.Classes;

public class ClassLevelRegisterDto
{
    public Guid ClassId { get; set; }
    public Guid LevelId { get; set; }
    public byte ProficiencyBonus { get; set; }
}
