namespace RPGManager.Desktop.Domain.DTOs;

public class DamageTypeModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; } = null!;
    //public GameSystemModel GameSystem { get; set; }
}