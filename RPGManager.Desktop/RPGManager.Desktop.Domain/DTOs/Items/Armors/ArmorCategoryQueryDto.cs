namespace RPGManager.Desktop.Domain.DTOs.Items.Armors;

public class ArmorCategoryQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
