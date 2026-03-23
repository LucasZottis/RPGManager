namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class WearableArmor : Armor
{
    public Guid? AmorClasscAbilityScoreModifierId { get; set; }

    public byte BaseArmorClass { get; set; }
    public bool AppliesAbilityModifier { get; set; }
    public byte? MaxAbilityModifier { get; set; }

    public AbilityScore? ArmorClassAbilityScoreModifier { get; set; }
}