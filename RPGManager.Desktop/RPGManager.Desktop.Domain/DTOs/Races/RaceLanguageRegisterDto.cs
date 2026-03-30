namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceLanguageRegisterDto
{
    public Guid RaceId { get; set; }
    public Guid? LanguageId { get; set; }
    public bool IsChoice { get; set; }
}
