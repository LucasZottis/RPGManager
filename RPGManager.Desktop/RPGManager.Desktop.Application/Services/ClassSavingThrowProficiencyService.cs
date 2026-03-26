using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassSavingThrowProficiencyService : CrudServiceBase<ClassSavingThrowProficiency, ClassSavingThrowProficiencyRegisterDto, ClassSavingThrowProficiencyQueryDto>, IClassSavingThrowProficiencyService
{
    public ClassSavingThrowProficiencyService( IClassSavingThrowProficiencyRepository repository, IClassSavingThrowProficiencyMapper mapper ) : base( repository, mapper )
    {
    }
}
