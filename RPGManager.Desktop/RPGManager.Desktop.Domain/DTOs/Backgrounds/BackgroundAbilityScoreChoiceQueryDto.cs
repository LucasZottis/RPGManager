namespace RPGManager.Desktop.Domain.DTOs.Backgrounds;

public class BackgroundAbilityScoreChoiceQueryDto
{
    public Guid Id { get; set; }
    public Guid BackgroundId { get; set; }
    public byte AllowedChoices { get; set; }
}
