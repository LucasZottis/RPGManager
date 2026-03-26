using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassStartingEquipmentChoiceService : CrudServiceBase<ClassStartingEquipmentChoice, ClassStartingEquipmentChoiceRegisterDto, ClassStartingEquipmentChoiceQueryDto>, IClassStartingEquipmentChoiceService
{
    public ClassStartingEquipmentChoiceService( IClassStartingEquipmentChoiceRepository repository, IClassStartingEquipmentChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
