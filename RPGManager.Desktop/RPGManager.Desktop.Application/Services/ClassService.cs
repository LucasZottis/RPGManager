using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassService : CrudServiceBase<Class, ClassRegisterDto, ClassQueryDto>, IClassService
{
    public ClassService( IClassRepository repository, IClassMapper mapper ) : base( repository, mapper )
    {
    }
}