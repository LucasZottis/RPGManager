namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponRegisterDto
{
    public Guid ItemId { get; set; }
    public Guid WeaponCategoryId { get; set; }
    public Guid WeaponTypeId { get; set; }
    public Guid WeaponMasteryPropertyId { get; set; }
    public Guid BaseAbilityScoreId { get; set; }
}
