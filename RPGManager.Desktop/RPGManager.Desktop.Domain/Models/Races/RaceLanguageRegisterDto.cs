namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceLanguageRegisterDto
{
    public Guid RaceId { get; set; }
    public Guid? LanguageId { get; set; }
    public bool IsChoice { get; set; }
}
