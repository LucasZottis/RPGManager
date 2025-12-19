namespace RpgContentCreator.Application.Models;

public class AlignmentModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public GameSystemModel GameSystem { get; set; }
}