using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Models.Items.Weapons;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IWeaponDamageService : ICrudServiceBase<WeaponDamage, WeaponDamageRegisterDto, WeaponDamageQueryDto>
{
}
