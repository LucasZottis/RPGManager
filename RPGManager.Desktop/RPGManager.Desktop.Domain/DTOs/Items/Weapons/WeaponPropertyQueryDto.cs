namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponPropertyQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public Guid? AlternativeAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool HasAlternativeDiceTypeDamage { get; set; }
}
