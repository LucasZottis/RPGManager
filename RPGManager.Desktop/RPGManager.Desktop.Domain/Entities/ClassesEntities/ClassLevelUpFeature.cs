namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassLevelUpFeature
{
    public Guid ClassId { get; set; }
    public Guid FeatureId { get; set; }
    public Guid LevelUpId { get; set; }

    public byte MaxUses { get; set; }
    public byte AdditionalDamage { get; set; }
    public byte WeaponMasteryAmount { get; set; }

    public Class Class { get; set; }
    public Feature Feature { get; set; }
    public LevelUp LevelUp { get; set; }
}