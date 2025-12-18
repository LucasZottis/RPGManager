namespace RpgContentCreator.Application.Models;

public class LanguageModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Alphabet { get; set; }

    public GameSystemModel GameSystem { get; set; }
}