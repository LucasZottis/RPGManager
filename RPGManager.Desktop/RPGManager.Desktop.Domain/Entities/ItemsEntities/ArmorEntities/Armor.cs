namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class Armor : Item
{
    public Guid ArmorCategoryId { get; set; }
    public Guid? RequiredAbilityScoreId { get; set; }

    public byte RequiredAbilityScoreMinimum { get; set; }
    public bool DisadvantageOnStealth { get; set; }

    public ArmorCategory ArmorCategory { get; set; }
    public AbilityScore? RequiredAbilityScore { get; set; }
}