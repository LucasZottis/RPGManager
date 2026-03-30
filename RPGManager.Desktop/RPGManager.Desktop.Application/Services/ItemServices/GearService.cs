using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Items.Gears;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

namespace RPGManager.Desktop.Application.Services.ItemServices;

public class GearService : CrudServiceBase<Gear, GearRegisterDto, GearQueryDto>, IGearService
{
    public GearService( IGearRepository repository, IGearMapper mapper ) : base( repository, mapper )
    {
    }
}
