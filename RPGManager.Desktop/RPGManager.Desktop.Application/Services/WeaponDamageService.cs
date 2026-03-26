using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Models.Items.Weapons;

namespace RPGManager.Desktop.Application.Services;

public class WeaponDamageService : CrudServiceBase<WeaponDamage, WeaponDamageRegisterDto, WeaponDamageQueryDto>, IWeaponDamageService
{
    public WeaponDamageService( IWeaponDamageRepository repository, IWeaponDamageMapper mapper ) : base( repository, mapper )
    {
    }
}
