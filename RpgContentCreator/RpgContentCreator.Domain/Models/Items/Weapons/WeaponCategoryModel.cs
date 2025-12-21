namespace RpgContentCreator.Domain.Models.Items.Weapons;

public class WeaponCategoryModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; } = null!;
}