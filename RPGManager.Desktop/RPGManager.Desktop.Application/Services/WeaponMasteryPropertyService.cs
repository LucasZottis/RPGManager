using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Models.Items.Weapons;

namespace RPGManager.Desktop.Application.Services;

public class WeaponMasteryPropertyService : CrudServiceBase<WeaponMasteryProperty, WeaponMasteryPropertyRegisterDto, WeaponMasteryPropertyQueryDto>, IWeaponMasteryPropertyService
{
    public WeaponMasteryPropertyService( IWeaponMasteryPropertyRepository repository, IWeaponMasteryPropertyMapper mapper ) : base( repository, mapper )
    {
    }
}
