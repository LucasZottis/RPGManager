namespace RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;

public class BackgroundAbilityScoreOption
{
    public Guid BackgroundAbilityScoreChoiceId { get; set; }
    public Guid AbilityScoreId { get; set; }

    public BackgroundAbilityScoreChoice BackgroundAbilityScoreChoice { get; set; }
    public AbilityScore AbilityScore { get; set; }
}