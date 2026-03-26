using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassSkillProficiencyChoiceService : CrudServiceBase<ClassSkillProficiencyChoice, ClassSkillProficiencyChoiceRegisterDto, ClassSkillProficiencyChoiceQueryDto>, IClassSkillProficiencyChoiceService
{
    public ClassSkillProficiencyChoiceService( IClassSkillProficiencyChoiceRepository repository, IClassSkillProficiencyChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
