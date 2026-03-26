namespace RPGManager.Desktop.Domain.Models.Items.Weapons;

public class WeaponMasteryPropertyQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
