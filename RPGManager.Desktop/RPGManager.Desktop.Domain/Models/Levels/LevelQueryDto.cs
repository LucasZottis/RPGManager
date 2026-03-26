namespace RPGManager.Desktop.Domain.Models.Levels;

public class LevelQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public byte LevelNumber { get; set; }
    public uint ExperiencePoints { get; set; }
    public byte ProficiencyBonus { get; set; }
}
