namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassSavingThrowProficiency
{
    public Guid ClassId { get; set; }
    public Guid AbilityScoreId { get; set; }

    public Class Class { get; set; }
    public AbilityScore AbilityScore { get; set; }
}