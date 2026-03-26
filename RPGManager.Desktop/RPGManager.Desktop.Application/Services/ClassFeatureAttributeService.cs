using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassFeatureAttributeService : CrudServiceBase<ClassFeatureAttribute, ClassFeatureAttributeRegisterDto, ClassFeatureAttributeQueryDto>, IClassFeatureAttributeService
{
    public ClassFeatureAttributeService( IClassFeatureAttributeRepository repository, IClassFeatureAttributeMapper mapper ) : base( repository, mapper )
    {
    }
}
