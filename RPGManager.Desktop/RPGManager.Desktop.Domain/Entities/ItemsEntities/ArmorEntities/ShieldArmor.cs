namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class ShieldArmor : Armor
{
    public byte ArmorClassBonus { get; set; }

    public Armor Armor { get; set; }
}