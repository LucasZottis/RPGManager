using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassFeatureAttributeLevelService : CrudServiceBase<ClassFeatureAttributeLevel, ClassFeatureAttributeLevelRegisterDto, ClassFeatureAttributeLevelQueryDto>, IClassFeatureAttributeLevelService
{
    public ClassFeatureAttributeLevelService( IClassFeatureAttributeLevelRepository repository, IClassFeatureAttributeLevelMapper mapper ) : base( repository, mapper )
    {
    }
}
