namespace RPGManager.Desktop.Domain.DTOs.Languages;

public class LanguageRegisterDto
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Alphabet { get; set; }
}
