using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IClassFeatureAttributeLevelService : ICrudServiceBase<ClassFeatureAttributeLevel, ClassFeatureAttributeLevelRegisterDto, ClassFeatureAttributeLevelQueryDto>
{
}
