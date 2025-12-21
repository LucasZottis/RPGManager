namespace RpgContentCreator.Domain.Models.Items.Weapons;

public class WeaponDamageModel
{
    public Guid WeaponId { get; set; }
    public Guid DamageTypeId { get; set; }

    public int? AttackIncrease { get; set; }
    public int? DamageDieCount { get; set; }
    public int? DamageDieType { get; set; }

    public int? AlternativeDamageDieCount { get; set; }
    public int? AlternativeDamageDieType { get; set; }

    public int? DamageIncrease { get; set; }
}