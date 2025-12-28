namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceSkillProficiency
{
    public Guid RaceId { get; set; }
    public Guid SkillId { get; set; }
    public bool IsExpertise { get; set; }

    public Race Race { get; set; }

    public Skill Skill { get; set; }
}