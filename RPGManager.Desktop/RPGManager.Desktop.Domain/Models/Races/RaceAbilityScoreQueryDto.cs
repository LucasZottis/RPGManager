namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceAbilityScoreQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceId { get; set; }
    public Guid AbilityScoreId { get; set; }
    public int Increase { get; set; }
}
