namespace RpgContentCreator.Application.Models.Items.Weapons;

public class WeaponGroupModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; } = null!;
}