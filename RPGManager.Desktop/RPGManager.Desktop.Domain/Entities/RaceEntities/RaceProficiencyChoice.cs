namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceProficiencyChoice : EntityBase
{
    public Guid RaceId { get; set; }
    public int MaxChoices { get; set; }

    public ICollection<RaceToolProficiency>? ToolProficiencies { get; set; }
}