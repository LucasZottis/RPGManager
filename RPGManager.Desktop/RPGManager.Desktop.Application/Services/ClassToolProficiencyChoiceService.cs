using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassToolProficiencyChoiceService : CrudServiceBase<ClassToolProficiencyChoice, ClassToolProficiencyChoiceRegisterDto, ClassToolProficiencyChoiceQueryDto>, IClassToolProficiencyChoiceService
{
    public ClassToolProficiencyChoiceService( IClassToolProficiencyChoiceRepository repository, IClassToolProficiencyChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
