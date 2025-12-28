namespace RPGManager.Desktop.Domain.Models;

public class LanguageModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Alphabet { get; set; }
}