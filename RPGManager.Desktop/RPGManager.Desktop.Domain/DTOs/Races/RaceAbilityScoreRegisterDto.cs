namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceAbilityScoreRegisterDto
{
    public Guid RaceId { get; set; }
    public Guid AbilityScoreId { get; set; }
    public int Increase { get; set; }
}
