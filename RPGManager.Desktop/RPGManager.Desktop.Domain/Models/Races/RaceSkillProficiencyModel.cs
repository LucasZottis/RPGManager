namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceSkillProficiencyModel
{
    public Guid RaceId { get; set; }
    public Guid SkillId { get; set; }
    public bool IsExpertise { get; set; }
}