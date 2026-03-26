namespace RPGManager.Desktop.Domain.Models.Items.Armors;

public class ArmorCategoryRegisterDto
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
