using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Models.Items.Gears;

namespace RPGManager.Desktop.Application.Services;

public class AmmunitionTypeService : CrudServiceBase<AmmunitionType, AmmunitionTypeRegisterDto, AmmunitionTypeQueryDto>, IAmmunitionTypeService
{
    public AmmunitionTypeService( IAmmunitionTypeRepository repository, IAmmunitionTypeMapper mapper ) : base( repository, mapper )
    {
    }
}
