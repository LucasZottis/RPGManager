using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Models.Items.Gears;

namespace RPGManager.Desktop.Application.Services;

public class GearService : CrudServiceBase<Gear, GearRegisterDto, GearQueryDto>, IGearService
{
    public GearService( IGearRepository repository, IGearMapper mapper ) : base( repository, mapper )
    {
    }
}
