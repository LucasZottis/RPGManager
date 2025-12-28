using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Models.Items.Weapons;

namespace RPGManager.Desktop.Application.Services;

public class WeaponPropertyService : ServiceBase<WeaponProperty, WeaponPropertyModel>, IWeaponPropertyService
{
    public WeaponPropertyService( IWeaponPropertyRepository repository, IWeaponPropertyMapper mapper ) : base( repository, mapper )
    {
    }
}