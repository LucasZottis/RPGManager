namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceLanguageQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceId { get; set; }
    public Guid? LanguageId { get; set; }
    public bool IsChoice { get; set; }
}
