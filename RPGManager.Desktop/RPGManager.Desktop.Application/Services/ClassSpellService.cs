using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassSpellService : CrudServiceBase<ClassSpell, ClassSpellRegisterDto, ClassSpellQueryDto>, IClassSpellService
{
    public ClassSpellService( IClassSpellRepository repository, IClassSpellMapper mapper ) : base( repository, mapper )
    {
    }
}
