namespace RPGManager.Desktop.Domain.Models.Languages;

public class LanguageRegisterDto
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Alphabet { get; set; }
}
