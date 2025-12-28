using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Domain.Models.Items.Armor;

namespace RPGManager.Desktop.Application.Services;

public class ArmorCategoryService : ServiceBase<ArmorCategory, ArmorCategoryModel>, IArmorCategoryService
{
    public ArmorCategoryService( IArmorCategoryRepository repository, IArmorCategoryMapper mapper ) : base( repository, mapper )
    {
    }
}