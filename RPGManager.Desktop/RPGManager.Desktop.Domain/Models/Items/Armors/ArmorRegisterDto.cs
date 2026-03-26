namespace RPGManager.Desktop.Domain.Models.Items.Armors;

public class ArmorRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public Guid ArmorCategoryId { get; set; }
    public Guid? RequiredAbilityScoreId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
    public byte RequiredAbilityScoreMinimum { get; set; }
    public bool DisadvantageOnStealth { get; set; }
}
