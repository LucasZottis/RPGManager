namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassLevelUp
{
    public Guid ClassId { get; set; }
    public Guid LevelUpId { get; set; }

    public string Description { get; set; }

    public byte AdditionalHitDice { get; set; }
    public byte ProficiencyBonus { get; set; }

    public Class Class { get; set; }
    public LevelUp LevelUp { get; set; }
}