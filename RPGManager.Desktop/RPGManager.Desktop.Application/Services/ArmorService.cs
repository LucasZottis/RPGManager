using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Domain.Models.Items.Armor;

namespace RPGManager.Desktop.Application.Services;

public class ArmorService : CrudServiceBase<Armor, ArmorRegisterDto, ArmorQueryDto>, IArmorService
{
    public ArmorService( IArmorRepository repository, IArmorMapper mapper ) : base( repository, mapper )
    {
    }
}
