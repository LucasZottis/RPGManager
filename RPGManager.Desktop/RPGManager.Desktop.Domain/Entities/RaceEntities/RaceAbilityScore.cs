using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceAbilityScore : EntityBase
{
    public Guid RaceId { get; set; }
    public Guid AbilityScoreId { get; set; }
    public int Increase { get; set; } = 1;

    public Race Race { get; set; }
    public AbilityScore AbilityScore { get; set; }
}