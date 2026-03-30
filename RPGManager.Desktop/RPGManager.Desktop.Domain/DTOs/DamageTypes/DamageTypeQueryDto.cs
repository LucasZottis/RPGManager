namespace RPGManager.Desktop.Domain.DTOs.DamageTypes;

public class DamageTypeQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
}
