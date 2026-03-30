namespace RPGManager.Desktop.Domain.DTOs.Items.Armor;

public class ArmorCategoryModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}