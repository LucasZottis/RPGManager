using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Items.Weapons;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.ItemServices.WeaponServices;

namespace RPGManager.Desktop.Application.Services.ItemServices.WeaponServices;

public class WeaponDamageService : CrudServiceBase<WeaponDamage, WeaponDamageRegisterDto, WeaponDamageQueryDto>, IWeaponDamageService
{
    public WeaponDamageService( IWeaponDamageRepository repository, IWeaponDamageMapper mapper ) : base( repository, mapper )
    {
    }
}
