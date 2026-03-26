using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Models.Items.Weapons;

namespace RPGManager.Desktop.Application.Services;

public class WeaponDamageDiceTypeService : CrudServiceBase<WeaponDamageDiceType, WeaponDamageDiceTypeRegisterDto, WeaponDamageDiceTypeQueryDto>, IWeaponDamageDiceTypeService
{
    public WeaponDamageDiceTypeService( IWeaponDamageDiceTypeRepository repository, IWeaponDamageDiceTypeMapper mapper ) : base( repository, mapper )
    {
    }
}
