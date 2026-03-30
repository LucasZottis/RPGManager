namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponPropertyModel
{
    public Guid Id { get; set; }
    public Guid? AlternativeAbilityScoreId { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    //public bool AltersDamage { get; set; }
    //public bool RequiresAlternativeDamage { get; set; }
    public bool HasAlternativeDamage {get; set;}
    //public bool AllowsAttributeOverride { get; set; }
}