namespace RPGManager.Desktop.Domain.Models.DamageTypes;

public class DamageTypeQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
}
