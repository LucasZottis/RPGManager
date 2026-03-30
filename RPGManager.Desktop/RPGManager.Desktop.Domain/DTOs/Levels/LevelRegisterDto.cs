namespace RPGManager.Desktop.Domain.DTOs.Levels;

public class LevelRegisterDto
{
    public Guid GameSystemId { get; set; }
    public byte LevelNumber { get; set; }
    public uint ExperiencePoints { get; set; }
    public byte ProficiencyBonus { get; set; }
}
