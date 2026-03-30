namespace RPGManager.Desktop.Domain.DTOs.Items.Armors;

public class WearableArmorRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public Guid ArmorCategoryId { get; set; }
    public Guid? RequiredAbilityScoreId { get; set; }
    public Guid? ArmorClassAbilityScoreModifierId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
    public byte RequiredAbilityScoreMinimum { get; set; }
    public bool DisadvantageOnStealth { get; set; }
    public byte BaseArmorClass { get; set; }
    public bool AppliesAbilityModifier { get; set; }
    public byte? MaxAbilityModifier { get; set; }
}
