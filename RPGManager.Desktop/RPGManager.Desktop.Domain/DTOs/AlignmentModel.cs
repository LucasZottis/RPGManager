namespace RPGManager.Desktop.Domain.DTOs;

public class AlignmentModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    //public GameSystemModel GameSystem { get; set; }
}