using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Models.Items.Weapons;

namespace RPGManager.Desktop.Application.Services;

public class WeaponCategoryService : ServiceBase<WeaponCategory, WeaponCategoryModel>, IWeaponCategoryService
{
    public WeaponCategoryService( IWeaponCategoryRepository repository, IWeaponCategoryMapper mapper ) : base( repository, mapper )
    {
    }
}