using RPGManager.Desktop.Domain.DTOs.Classes;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.ClassServices;

public interface IClassStartingEquipmentItemService : ICrudServiceBase<ClassStartingEquipmentItem, ClassStartingEquipmentItemRegisterDto, ClassStartingEquipmentItemQueryDto>
{
}
