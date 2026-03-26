using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class SubClassService : CrudServiceBase<SubClass, SubClassRegisterDto, SubClassQueryDto>, ISubClassService
{
    public SubClassService( ISubClassRepository repository, ISubClassMapper mapper ) : base( repository, mapper )
    {
    }
}
