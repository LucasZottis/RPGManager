using RPGManager.Desktop.Application.Mappers.Interfaces;
using RPGManager.Desktop.Application.Services.Interfaces;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassService : CrudServiceBase<Class, ClassRegisterDto, ClassQueryDto>, IClassService
{
    public ClassService( IClassRepository repository, IClassMapper mapper ) : base( repository, mapper )
    {
    }
}