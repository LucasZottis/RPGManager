using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassStartingEquipmentItemService : CrudServiceBase<ClassStartingEquipmentItem, ClassStartingEquipmentItemRegisterDto, ClassStartingEquipmentItemQueryDto>, IClassStartingEquipmentItemService
{
    public ClassStartingEquipmentItemService( IClassStartingEquipmentItemRepository repository, IClassStartingEquipmentItemMapper mapper ) : base( repository, mapper )
    {
    }
}
