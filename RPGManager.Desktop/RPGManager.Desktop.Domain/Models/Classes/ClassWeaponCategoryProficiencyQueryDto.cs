namespace RPGManager.Desktop.Domain.Models.Classes;

public class ClassWeaponCategoryProficiencyQueryDto
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public Guid WeaponCategoryId { get; set; }
}
