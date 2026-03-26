using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassFeatureService : CrudServiceBase<ClassFeature, ClassFeatureRegisterDto, ClassFeatureQueryDto>, IClassFeatureService
{
    public ClassFeatureService( IClassFeatureRepository repository, IClassFeatureMapper mapper ) : base( repository, mapper )
    {
    }
}
