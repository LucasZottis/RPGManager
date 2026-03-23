namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class Armor : Item
{
    public Guid ItemId { get; set; }
    public Guid ArmorCategoryId { get; set; }
    public Guid? RequiredAbilityScoreId { get; set; }

    public byte RequiredAbilityScoreMinimum { get; set; }
    public bool DisadvantageOnStealth { get; set; }

    public Item Item { get; set; }
    public ArmorCategory ArmorCategory { get; set; }
    public AbilityScore? RequiredAbilityScore { get; set; }
}